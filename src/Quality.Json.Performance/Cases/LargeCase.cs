using Quality.Json.Performance.Domain;
using Quality.Json.Performance.Requirements;
using Quality.Json.Performance.Resources;
using SevenZip.SDK.Compress.LZMA;
using System;
using System.Collections.Generic;
using System.IO;

namespace Quality.Json.Performance.Cases
{
    [Serializable]
    public class LargeCase : ICase, IResource<Large>
    {
        public string Name
        {
            get { return "Large"; }
        }

        public string Description
        {
            get { return null; }
        }

        public IEnumerable<IRequirement> GetRequirements()
        {
            yield return new JsonOnlyRequirement();
            yield return new DeserializeOnlyRequirement();
        }

        public IResultData Execute(IProcedure procedure, ISubject subject, ITimes times)
        {
            return procedure.Process(this, subject, times);
        }

        public string GetText()
        {
            using (MemoryStream memory = new MemoryStream())
            {
                using (Stream input = File.OpenRead(@"Resources\Large.7z"))
                {
                    Decoder coder = new Decoder();

                    // Read the decoder properties
                    byte[] properties = new byte[5];
                    input.Read(properties, 0, 5);

                    // Read in the decompress file size.
                    byte[] fileLengthBytes = new byte[8];
                    input.Read(fileLengthBytes, 0, 8);
                    long fileLength = BitConverter.ToInt64(fileLengthBytes, 0);

                    coder.SetDecoderProperties(properties);
                    coder.Code(input, memory, input.Length, fileLength, null);

                    memory.Flush();
                }

                memory.Seek(0, SeekOrigin.Begin);

                using (TextReader reader = new StreamReader(memory))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        public MemoryStream GetData()
        {
            throw new NotSupportedException();
        }

        public ITimes Multiply(ITimes times)
        {
            return times.Multiply(1);
        }

        public Large GetInstance()
        {
            return new Large
            {
                all_ascii = new Large.Text
                {
                    here = File.ReadAllText(@"Resources\Large.ascii")
                },
                all_unicode = new Large.Text
                {
                    here = File.ReadAllText(@"Resources\Large.unicode")
                },
                json_data = new Large.Data { },
                some_html = new Large.Html
                {
                    credits = @"http://www.immigration-usa.com/html_colors.html"
                }
            };
        }
    }
}
