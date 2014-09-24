using Quality.Json.Performance.Domain;
using Quality.Json.Performance.Resources;
using System;
using System.Collections.Generic;
using System.IO;

namespace Quality.Json.Performance.Cases
{
    [Serializable]
    public class RowCase : ICase, IResource<Row>
    {
        public string Name
        {
            get { return "Row"; }
        }

        public string Description
        {
            get { return null; }
        }

        public IEnumerable<IRequirement> GetRequirements()
        {
            yield break;
        }

        public IResultData Execute(IProcedure procedure, ISubject subject)
        {
            return procedure.Process(this, subject);
        }

        public string GetText()
        {
            return File.ReadAllText(@"Resources\Row.json");
        }

        public byte[] GetData()
        {
            return File.ReadAllBytes(@"Resources\Row.json");
        }

        public int Multiply(int times)
        {
            return times * 100;
        }

        public Row GetInstance()
        {
            return new Row
            {
                id = "5408a8fe87b96565151fd386",
                index = 17,
                guid = "76cbf5d2-7212-4586-9db6-a5c6bdac9c56",
                isActive = false,
                balance = "$3,143.46",
                picture = "http://placehold.it/32x32",
                age = 36,
                eyeColor = "green",
                name = "Craft Arnold",
                gender = "male",
                company = "ZOUNDS",
                email = "craftarnold@zounds.com",
                phone = "+1 (983) 535-2003",
                address = "431 Rewe Street, Norwood, American Samoa, 7252",
                about = "Laboris deserunt in culpa commodo anim est et officia enim adipisicing ea do. Occaecat consequat exercitation cupidatat commodo aliquip nulla officia tempor fugiat irure cupidatat. Proident sunt voluptate reprehenderit deserunt voluptate. Nulla et non consequat dolor. Dolore commodo in aliquip sint est non sit veniam duis reprehenderit culpa fugiat dolor sint. Magna sint labore mollit veniam elit mollit nulla minim aliqua.\r\n",
                registered = "2014-06-22T09:40:21 -02:00",
                latitude = 49.911697,
                longitude = -6.562665,
                tags = new string[] { "incididunt", "laborum", "proident", "quis", "do", "dolor", "reprehenderit" },
                friends = new[]
                {
                    new Row.Friend { id = 0, name = "Maryann Rocha" },
                    new Row.Friend { id = 1, name = "Stevens Luna" },
                    new Row.Friend { id = 2, name = "Sanders Cantu" }
                },
                greeting = "Hello, Craft Arnold! You have 3 unread messages.",
                favoriteFruit = "banana"
            };
        }
    }
}