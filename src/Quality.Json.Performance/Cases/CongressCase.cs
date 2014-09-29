﻿using Quality.Json.Performance.Domain;
using Quality.Json.Performance.Resources;
using System;
using System.Collections.Generic;
using System.IO;

namespace Quality.Json.Performance.Cases
{
    [Serializable]
    public class CongressCase : ICase, IResource<CongressContainer>
    {
        public string Name
        {
            get { return "Congress"; }
        }

        public string Description
        {
            get { return null; }
        }

        public IEnumerable<IRequirement> GetRequirements()
        {
            yield break;
        }

        public IResultData Execute(IProcedure procedure, ISubject subject, ITimes times)
        {
            return procedure.Process(this, subject, times);
        }

        public string GetText()
        {
            return File.ReadAllText(@"Resources\Congress.json");
        }

        public byte[] GetData()
        {
            return File.ReadAllBytes(@"Resources\Congress.json");
        }

        public ITimes Multiply(ITimes times)
        {
            return times.Multiply(2);
        }

        public CongressContainer GetInstance()
        {
            return new CongressContainer
            {
                bill_id = "hr4015-113",
                bill_type = "hr",
                by_request = false,
                congress = "113",
                introduced_at = "2014-02-06",
                number = "4015",
                official_title = "To amend title XVIII of the Social Security Act to repeal the Medicare sustainable growth rate and improve Medicare payments for physicians and other professionals, and for other purposes.",
                short_title = "SGR Repeal and Medicare Provider Payment Modernization Act of 2014",
                status = "PASS_OVER:HOUSE",
                status_at = "2014-03-14T11:16:00-04:00",
                subjects_top_term = "Health",
                updated_at = "2014-09-13T06:55:49-04:00",
                actions = new[]
                {
                    new CongressContainer.Action
                    {
                        acted_at = "2014-02-06",
                        committees = new string[] { "HSIF" },
                        references = new CongressContainer.Reference[] { },
                        status = "REFERRED",
                        text = "Referred to the Committee on Energy and Commerce, and in addition to the Committees on Ways and Means, and the Judiciary, for a period to be subsequently determined by the Speaker, in each case for consideration of such provisions as fall within the jurisdiction of the committee concerned.",
                        type = "referral"
                    },
                    new CongressContainer.Action
                    {
                        acted_at = "2014-02-06",
                        committees = new string[] { "HSIF" },
                        references = new CongressContainer.Reference[] { },
                        text = "Referred to House Energy and Commerce",
                        type = "referral"
                    },
                    new CongressContainer.Action
                    {
                        acted_at = "2014-02-06",
                        committees = new string[] { "HSWM" },
                        references = new CongressContainer.Reference[] { },
                        text = "Referred to House Ways and Means",
                        type = "referral"
                    },
                    new CongressContainer.Action
                    {
                        acted_at = "2014-02-06",
                        committees = new string[] { "HSJU" },
                        references = new CongressContainer.Reference[] { },
                        text = "Referred to House Judiciary",
                        type = "referral"
                    },
                    new CongressContainer.Action
                    {
                        acted_at = "2014-02-07",
                        references = new CongressContainer.Reference[] { },
                        text = "Referred to the Subcommittee on Health.",
                        type = "referral"
                    },
                    new CongressContainer.Action
                    {
                        acted_at = "2014-02-25",
                        references = new[]
                        {
                            new CongressContainer.Reference { reference = "CR H1885-1886" }
                        },
                        text = "Sponsor introductory remarks on measure.",
                        type = "action"
                    },
                    new CongressContainer.Action
                    {
                        acted_at = "2014-03-12T19:24:00-04:00",
                        bill_ids = new string[] { "hres515-113", "hr3189-113" },
                        committees = new string[] { "HSRU" },
                        references = new CongressContainer.Reference[] { },
                        text = "Rules Committee Resolution H. Res. 515 Reported to House. The resolution provides for one hour of debate on H.R. 3189. The rule makes in order as original text for the purpose of amendment an amendment in the nature of a substitute recommended by the Committee on Natural Resources now printed in the bill and provides that it shall be considered as read. The rule provides for a closed rule for H.R. 4015 with one hour of debate on the bill.",
                        type = "action"
                    },
                    new CongressContainer.Action
                    {
                        acted_at = "2014-03-13T14:25:00-04:00",
                        bill_ids = new string[] { "hres515-113" },
                        references = new CongressContainer.Reference[] { },
                        text = "Rule H. Res. 515 passed House.",
                        type = "action"
                    },
                    new CongressContainer.Action
                    {
                        acted_at = "2014-03-14T09:16:00-04:00",
                        bill_ids = new string[] { "hres515-113" },
                        references = new[]
                        {
                            new CongressContainer.Reference { reference = "CR H2439-2470", type = "consideration" },
                        },
                        text = "Considered under the provisions of rule H. Res. 515.",
                        type = "action"
                    },
                    new CongressContainer.Action
                    {
                        acted_at = "2014-03-14T09:16:00-04:00",
                        bill_ids = new string[] { "hr3189-113" },
                        committees = new string[] { "HSII" },
                        references = new CongressContainer.Reference[] { },
                        text = "The resolution provides for one hour of debate on H.R. 3189. The rule makes in order as original text for the purpose of amendment an amendment in the nature of a substitute recommended by the Committee on Natural Resources now printed in the bill and provides that it shall be considered as read. The rule provides for a closed rule for H.R. 4015 with one hour of debate on the bill.",
                        type = "action"
                    },
                    new CongressContainer.Action
                    {
                        acted_at = "2014-03-14T09:17:00-04:00",
                        references = new CongressContainer.Reference[] { },
                        text = "DEBATE - The House proceeded with one hour of debate on H.R. 4015.",
                        type = "action"
                    },
                    new CongressContainer.Action
                    {
                        acted_at = "2014-03-14T10:32:00-04:00",
                        references = new CongressContainer.Reference[] { },
                        text = "DEBATE - The House continued with debate on H.R. 4015.",
                        type = "action"
                    },
                    new CongressContainer.Action
                    {
                        acted_at = "2014-03-14T10:36:00-04:00",
                        references = new[]
                        {
                            new CongressContainer.Reference { reference = "CR H2468", type = "consideration" }
                        },
                        text = "The previous question was ordered pursuant to the rule.",
                        type = "action"
                    },
                    new CongressContainer.Action
                    {
                        acted_at = "2014-03-14T10:36:00-04:00",
                        committees = new string[] { "HSWM" },
                        references = new[]
                        {
                            new CongressContainer.Reference { reference = "CR H2468-1470", type = "consideration" },
                            new CongressContainer.Reference { reference = "CR H2468", type = "text" },
                        },
                        text = "Mr. Loebsack moved to recommit with instructions to Ways and Means.",
                        type = "action"
                    },
                    new CongressContainer.Action
                    {
                        acted_at = "2014-03-14T10:36:00-04:00",
                        references = new CongressContainer.Reference[] { },
                        text = "DEBATE - The House proceeded with 10 minutes of debate on the Loebsack motion to recommit with instructions, pending the reservation of a point of order. The instructions contained in the motion seek to require the bill to be reported back to the House with an amendment to add a section to the bill titled Prohibition on Medicare cuts or Vouchers. Subsequently, the reservation was withdrawn.",
                        type = "action"
                    },
                    new CongressContainer.Action
                    {
                        acted_at = "2014-03-14T10:43:00-04:00",
                        references = new[]
                        {
                            new CongressContainer.Reference { reference = "CR H2469", type = "consideration" }
                        },
                        text = "The previous question on the motion to recommit with instructions was ordered without objection.",
                        type = "action"
                    },
                    new CongressContainer.Action
                    {
                        acted_at = "2014-03-14T11:08:00-04:00",
                        references = new CongressContainer.Reference[] { },
                        text = "On motion to recommit with instructions Failed by the Yeas and Nays: 191 - 226 (Roll no. 134).",
                        type = "action"
                    },
                    new CongressContainer.Action
                    {
                        acted_at = "2014-03-14T11:16:00-04:00",
                        how = "roll",
                        references = new[]
                        {
                            new CongressContainer.Reference { reference = "CR H2439-2457", type = "text" }
                        },
                        result = "pass",
                        roll = "135",
                        status = "PASS_OVER:HOUSE",
                        text = "On passage Passed by the Yeas and Nays: 238 - 181 (Roll no. 135).",
                        type = "vote",
                        vote_type = "vote",
                        where = "h"
                    },
                    new CongressContainer.Action
                    {
                        acted_at = "2014-03-14T11:16:00-04:00",
                        references = new CongressContainer.Reference[] { },
                        text = "Motion to reconsider laid on the table Agreed to without objection.",
                        type = "action"
                    },
                    new CongressContainer.Action
                    {
                        acted_at = "2014-03-20",
                        references = new CongressContainer.Reference[] { },
                        text = "Referred to the Subcommittee on the Constitution and Civil Justice.",
                        type = "referral"
                    },
                    new CongressContainer.Action
                    {
                        acted_at = "2014-03-24",
                        references = new CongressContainer.Reference[] { },
                        text = "Received in the Senate.",
                        type = "action"
                    }
                },
                amendments = new[]
                {
                    new CongressContainer.Amendment
                    {
                        amendment_id = "hamdt598-113",
                        amendment_type = "hamdt",
                        chamber = "h",
                        number = "598"
                    }
                },
                committees = new[]
                {
                    new CongressContainer.Committee
                    {
                        activity = new string[] { "referral" },
                        committee = "House Energy and Commerce",
                        committee_id = "HSIF"
                    },
                    new CongressContainer.Committee
                    {
                        activity = new string[] { "referral" },
                        committee = "House Energy and Commerce",
                        committee_id = "HSIF",
                        subcommittee = "Subcommittee on Health",
                        subcommittee_id = "14"
                    },
                    new CongressContainer.Committee
                    {
                        activity = new string[] { "referral" },
                        committee = "House Ways and Means",
                        committee_id = "HSWM"
                    },
                    new CongressContainer.Committee
                    {
                        activity = new string[] { "referral" },
                        committee = "House Judiciary",
                        committee_id = "HSJU"
                    },
                    new CongressContainer.Committee
                    {
                        activity = new string[] { "referral" },
                        committee = "House Judiciary",
                        committee_id = "HSJU",
                        subcommittee = "Subcommittee on Constitution and Civil Justice",
                        subcommittee_id = "10"
                    }
                },
                cosponsors = new[]
                {
                    new CongressContainer.Cosponsor
                    {
                        district = "2",
                        name = "Amodei, Mark E.",
                        sponsored_at = "2014-03-10",
                        state = "NV",
                        thomas_id = "02090",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "6",
                        name = "Barr, Andy",
                        sponsored_at = "2014-03-05",
                        state = "KY",
                        thomas_id = "02131",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "12",
                        name = "Barrow, John",
                        sponsored_at = "2014-03-11",
                        state = "GA",
                        thomas_id = "01780",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "1",
                        name = "Benishek, Dan",
                        sponsored_at = "2014-02-28",
                        state = "MI",
                        thomas_id = "02027",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "7",
                        name = "Bera, Ami",
                        sponsored_at = "2014-02-28",
                        state = "CA",
                        thomas_id = "02102",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "12",
                        name = "Bilirakis, Gus M.",
                        sponsored_at = "2014-03-10",
                        state = "FL",
                        thomas_id = "01838",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "1",
                        name = "Bishop, Rob",
                        sponsored_at = "2014-03-06",
                        state = "UT",
                        thomas_id = "01753",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "2",
                        name = "Bishop, Sanford D., Jr.",
                        sponsored_at = "2014-03-05",
                        state = "GA",
                        thomas_id = "00091",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "6",
                        name = "Black, Diane",
                        sponsored_at = "2014-03-10",
                        state = "TN",
                        thomas_id = "02063",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "7",
                        name = "Blackburn, Marsha",
                        sponsored_at = "2014-03-05",
                        state = "TN",
                        thomas_id = "01748",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "3",
                        name = "Blumenauer, Earl",
                        sponsored_at = "2014-02-26",
                        state = "OR",
                        thomas_id = "00099",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = null,
                        name = "Bordallo, Madeleine Z.",
                        sponsored_at = "2014-02-26",
                        state = "GU",
                        thomas_id = "01723",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "3",
                        name = "Boustany, Charles W., Jr.",
                        sponsored_at = "2014-02-06",
                        state = "LA",
                        thomas_id = "01787",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "8",
                        name = "Brady, Kevin",
                        sponsored_at = "2014-02-06",
                        state = "TX",
                        thomas_id = "01468",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "16",
                        name = "Buchanan, Vern",
                        sponsored_at = "2014-03-05",
                        state = "FL",
                        thomas_id = "01840",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "8",
                        name = "Bucshon, Larry",
                        sponsored_at = "2014-02-26",
                        state = "IN",
                        thomas_id = "02018",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "4",
                        name = "Camp, Dave",
                        sponsored_at = "2014-02-06",
                        state = "MI",
                        thomas_id = "00166",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "2",
                        name = "Capito, Shelley Moore",
                        sponsored_at = "2014-03-10",
                        state = "WV",
                        thomas_id = "01676",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "1",
                        name = "Chabot, Steve",
                        sponsored_at = "2014-03-11",
                        state = "OH",
                        thomas_id = "00186",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "6",
                        name = "Coffman, Mike",
                        sponsored_at = "2014-03-06",
                        state = "CO",
                        thomas_id = "01912",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "9",
                        name = "Cohen, Steve",
                        sponsored_at = "2014-03-06",
                        state = "TN",
                        thomas_id = "01878",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = null,
                        name = "Cramer, Kevin",
                        sponsored_at = "2014-03-10",
                        state = "ND",
                        thomas_id = "02144",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "1",
                        name = "Crawford, Eric A. \"Rick\"",
                        sponsored_at = "2014-03-11",
                        state = "AR",
                        thomas_id = "01989",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "28",
                        name = "Cuellar, Henry",
                        sponsored_at = "2014-02-28",
                        state = "TX",
                        thomas_id = "01807",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "7",
                        name = "Davis, Danny K.",
                        sponsored_at = "2014-03-06",
                        state = "IL",
                        thomas_id = "01477",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "4",
                        name = "DeFazio, Peter A.",
                        sponsored_at = "2014-03-10",
                        state = "OR",
                        thomas_id = "00279",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "1",
                        name = "DeGette, Diana",
                        sponsored_at = "2014-03-05",
                        state = "CO",
                        thomas_id = "01479",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "15",
                        name = "Dent, Charles W.",
                        sponsored_at = "2014-03-05",
                        state = "PA",
                        thomas_id = "01799",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "12",
                        name = "Dingell, John D.",
                        sponsored_at = "2014-03-05",
                        state = "MI",
                        thomas_id = "00299",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "4",
                        name = "Edwards, Donna F.",
                        sponsored_at = "2014-03-05",
                        state = "MD",
                        thomas_id = "01894",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "2",
                        name = "Ellmers, Renee L.",
                        sponsored_at = "2014-03-10",
                        state = "NC",
                        thomas_id = "02036",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "18",
                        name = "Eshoo, Anna G.",
                        sponsored_at = "2014-03-06",
                        state = "CA",
                        thomas_id = "00355",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "20",
                        name = "Farr, Sam",
                        sponsored_at = "2014-02-26",
                        state = "CA",
                        thomas_id = "00368",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "8",
                        name = "Fitzpatrick, Michael G.",
                        sponsored_at = "2014-02-26",
                        state = "PA",
                        thomas_id = "01797",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "17",
                        name = "Flores, Bill",
                        sponsored_at = "2014-02-26",
                        state = "TX",
                        thomas_id = "02065",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "1",
                        name = "Fortenberry, Jeff",
                        sponsored_at = "2014-03-11",
                        state = "NE",
                        thomas_id = "01793",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "7",
                        name = "Gibbs, Bob",
                        sponsored_at = "2014-03-06",
                        state = "OH",
                        thomas_id = "02049",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "11",
                        name = "Gingrey, Phil",
                        sponsored_at = "2014-03-06",
                        state = "GA",
                        thomas_id = "01720",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "6",
                        name = "Graves, Sam",
                        sponsored_at = "2014-03-10",
                        state = "MO",
                        thomas_id = "01656",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "29",
                        name = "Green, Gene",
                        sponsored_at = "2014-02-26",
                        state = "TX",
                        thomas_id = "00462",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "2",
                        name = "Griffin, Tim",
                        sponsored_at = "2014-03-10",
                        state = "AR",
                        thomas_id = "01990",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "3",
                        name = "Grijalva, Raul M.",
                        sponsored_at = "2014-03-11",
                        state = "AZ",
                        thomas_id = "01708",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "11",
                        name = "Grimm, Michael G.",
                        sponsored_at = "2014-03-10",
                        state = "NY",
                        thomas_id = "02041",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "2",
                        name = "Guthrie, Brett",
                        sponsored_at = "2014-03-05",
                        state = "KY",
                        thomas_id = "01922",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "4",
                        name = "Hall, Ralph M.",
                        sponsored_at = "2014-02-28",
                        state = "TX",
                        thomas_id = "00484",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "22",
                        name = "Hanna, Richard L.",
                        sponsored_at = "2014-03-10",
                        state = "NY",
                        thomas_id = "02044",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "3",
                        name = "Harper, Gregg",
                        sponsored_at = "2014-03-06",
                        state = "MS",
                        thomas_id = "01933",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "10",
                        name = "Heck, Denny",
                        sponsored_at = "2014-03-05",
                        state = "WA",
                        thomas_id = "02170",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "3",
                        name = "Heck, Joseph J.",
                        sponsored_at = "2014-03-05",
                        state = "NV",
                        thomas_id = "02040",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "17",
                        name = "Honda, Michael M.",
                        sponsored_at = "2014-03-06",
                        state = "CA",
                        thomas_id = "01634",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "4",
                        name = "Horsford, Steven A.",
                        sponsored_at = "2014-03-06",
                        state = "NV",
                        thomas_id = "02147",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "8",
                        name = "Hudson, Richard",
                        sponsored_at = "2014-03-05",
                        state = "NC",
                        thomas_id = "02140",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "2",
                        name = "Huffman, Jared",
                        sponsored_at = "2014-03-05",
                        state = "CA",
                        thomas_id = "02101",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "3",
                        name = "Israel, Steve",
                        sponsored_at = "2014-03-11",
                        state = "NY",
                        thomas_id = "01663",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "6",
                        name = "Johnson, Bill",
                        sponsored_at = "2014-03-05",
                        state = "OH",
                        thomas_id = "02046",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "3",
                        name = "Johnson, Sam",
                        sponsored_at = "2014-03-11",
                        state = "TX",
                        thomas_id = "00603",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "3",
                        name = "Kelly, Mike",
                        sponsored_at = "2014-03-12",
                        state = "PA",
                        thomas_id = "02051",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "3",
                        name = "Kind, Ron",
                        sponsored_at = "2014-03-06",
                        state = "WI",
                        thomas_id = "01498",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "7",
                        name = "Lance, Leonard",
                        sponsored_at = "2014-03-10",
                        state = "NJ",
                        thomas_id = "01936",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "3",
                        name = "Latham, Tom",
                        sponsored_at = "2014-03-06",
                        state = "IA",
                        thomas_id = "00666",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "5",
                        name = "Latta, Robert E.",
                        sponsored_at = "2014-03-10",
                        state = "OH",
                        thomas_id = "01885",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "9",
                        name = "Levin, Sander M.",
                        sponsored_at = "2014-02-06",
                        state = "MI",
                        thomas_id = "00683",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "5",
                        name = "Lewis, John",
                        sponsored_at = "2014-03-10",
                        state = "GA",
                        thomas_id = "00688",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "2",
                        name = "LoBiondo, Frank A.",
                        sponsored_at = "2014-03-12",
                        state = "NJ",
                        thomas_id = "00699",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "7",
                        name = "Long, Billy",
                        sponsored_at = "2014-03-05",
                        state = "MO",
                        thomas_id = "02033",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "24",
                        name = "Maffei, Daniel B.",
                        sponsored_at = "2014-03-06",
                        state = "NY",
                        thomas_id = "01943",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "18",
                        name = "Maloney, Sean Patrick",
                        sponsored_at = "2014-03-10",
                        state = "NY",
                        thomas_id = "02150",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "4",
                        name = "Matheson, Jim",
                        sponsored_at = "2014-03-05",
                        state = "UT",
                        thomas_id = "01671",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "6",
                        name = "Matsui, Doris O.",
                        sponsored_at = "2014-03-05",
                        state = "CA",
                        thomas_id = "01814",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "10",
                        name = "McCaul, Michael T.",
                        sponsored_at = "2014-03-12",
                        state = "TX",
                        thomas_id = "01804",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "7",
                        name = "McDermott, Jim",
                        sponsored_at = "2014-02-06",
                        state = "WA",
                        thomas_id = "00766",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "10",
                        name = "McHenry, Patrick T.",
                        sponsored_at = "2014-03-11",
                        state = "NC",
                        thomas_id = "01792",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "1",
                        name = "McKinley, David B.",
                        sponsored_at = "2014-02-18",
                        state = "WV",
                        thomas_id = "02074",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "10",
                        name = "Miller, Candice S.",
                        sponsored_at = "2014-03-12",
                        state = "MI",
                        thomas_id = "01731",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "1",
                        name = "Miller, Jeff",
                        sponsored_at = "2014-03-06",
                        state = "FL",
                        thomas_id = "01685",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "18",
                        name = "Murphy, Tim",
                        sponsored_at = "2014-02-28",
                        state = "PA",
                        thomas_id = "01744",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "35",
                        name = "Negrete McLeod, Gloria",
                        sponsored_at = "2014-03-05",
                        state = "CA",
                        thomas_id = "02108",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = null,
                        name = "Norton, Eleanor Holmes",
                        sponsored_at = "2014-03-10",
                        state = "DC",
                        thomas_id = "00868",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "22",
                        name = "Nunes, Devin",
                        sponsored_at = "2014-02-28",
                        state = "CA",
                        thomas_id = "01710",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "16",
                        name = "O'Rourke, Beto",
                        sponsored_at = "2014-02-26",
                        state = "TX",
                        thomas_id = "02162",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "6",
                        name = "Pallone, Frank, Jr.",
                        sponsored_at = "2014-02-06",
                        state = "NJ",
                        thomas_id = "00887",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "3",
                        name = "Paulsen, Erik",
                        sponsored_at = "2014-03-06",
                        state = "MN",
                        thomas_id = "01930",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "2",
                        name = "Pearce, Stevan",
                        sponsored_at = "2014-02-18",
                        state = "NM",
                        thomas_id = "01738",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "14",
                        name = "Peters, Gary C.",
                        sponsored_at = "2014-03-05",
                        state = "MI",
                        thomas_id = "01929",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "6",
                        name = "Petri, Thomas E.",
                        sponsored_at = "2014-03-05",
                        state = "WI",
                        thomas_id = "00912",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "16",
                        name = "Pitts, Joseph R.",
                        sponsored_at = "2014-02-06",
                        state = "PA",
                        thomas_id = "01514",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "4",
                        name = "Pompeo, Mike",
                        sponsored_at = "2014-03-10",
                        state = "KS",
                        thomas_id = "02022",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "6",
                        name = "Price, Tom",
                        sponsored_at = "2014-03-05",
                        state = "GA",
                        thomas_id = "01778",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "3",
                        name = "Rahall, Nick J., II",
                        sponsored_at = "2014-03-06",
                        state = "WV",
                        thomas_id = "00940",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "13",
                        name = "Rangel, Charles B.",
                        sponsored_at = "2014-03-05",
                        state = "NY",
                        thomas_id = "00944",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "23",
                        name = "Reed, Tom",
                        sponsored_at = "2014-03-06",
                        state = "NY",
                        thomas_id = "01982",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "2",
                        name = "Rigell, E. Scott",
                        sponsored_at = "2014-03-11",
                        state = "VA",
                        thomas_id = "02068",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "1",
                        name = "Roe, David P.",
                        sponsored_at = "2014-02-28",
                        state = "TN",
                        thomas_id = "01954",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "8",
                        name = "Rogers, Mike J.",
                        sponsored_at = "2014-02-26",
                        state = "MI",
                        thomas_id = "01651",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "17",
                        name = "Rooney, Thomas J.",
                        sponsored_at = "2014-03-11",
                        state = "FL",
                        thomas_id = "01916",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "36",
                        name = "Ruiz, Raul",
                        sponsored_at = "2014-02-28",
                        state = "CA",
                        thomas_id = "02109",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "2",
                        name = "Ruppersberger, C. A. Dutch",
                        sponsored_at = "2014-03-05",
                        state = "MD",
                        thomas_id = "01728",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "1",
                        name = "Rush, Bobby L.",
                        sponsored_at = "2014-03-10",
                        state = "IL",
                        thomas_id = "01003",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = null,
                        name = "Sablan, Gregorio Kilili Camacho",
                        sponsored_at = "2014-03-05",
                        state = "MP",
                        thomas_id = "01962",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "5",
                        name = "Schrader, Kurt",
                        sponsored_at = "2014-03-05",
                        state = "OR",
                        thomas_id = "01950",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "13",
                        name = "Schwartz, Allyson Y.",
                        sponsored_at = "2014-02-26",
                        state = "PA",
                        thomas_id = "01798",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "13",
                        name = "Scott, David",
                        sponsored_at = "2014-03-05",
                        state = "GA",
                        thomas_id = "01722",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "32",
                        name = "Sessions, Pete",
                        sponsored_at = "2014-02-26",
                        state = "TX",
                        thomas_id = "01525",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "9",
                        name = "Shuster, Bill",
                        sponsored_at = "2014-03-10",
                        state = "PA",
                        thomas_id = "01681",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "21",
                        name = "Smith, Lamar",
                        sponsored_at = "2014-03-10",
                        state = "TX",
                        thomas_id = "01075",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "14",
                        name = "Speier, Jackie",
                        sponsored_at = "2014-03-06",
                        state = "CA",
                        thomas_id = "01890",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "15",
                        name = "Stivers, Steve",
                        sponsored_at = "2014-03-05",
                        state = "OH",
                        thomas_id = "02047",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "41",
                        name = "Takano, Mark",
                        sponsored_at = "2014-03-06",
                        state = "CA",
                        thomas_id = "02110",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "2",
                        name = "Terry, Lee",
                        sponsored_at = "2014-02-26",
                        state = "NE",
                        thomas_id = "01566",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "5",
                        name = "Thompson, Mike",
                        sponsored_at = "2014-03-05",
                        state = "CA",
                        thomas_id = "01593",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "13",
                        name = "Thornberry, Mac",
                        sponsored_at = "2014-02-28",
                        state = "TX",
                        thomas_id = "01155",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "12",
                        name = "Tiberi, Patrick J.",
                        sponsored_at = "2014-03-05",
                        state = "OH",
                        thomas_id = "01664",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "20",
                        name = "Tonko, Paul",
                        sponsored_at = "2014-03-06",
                        state = "NY",
                        thomas_id = "01942",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "6",
                        name = "Upton, Fred",
                        sponsored_at = "2014-02-06",
                        state = "MI",
                        thomas_id = "01177",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "2",
                        name = "Walorski, Jackie",
                        sponsored_at = "2014-03-10",
                        state = "IN",
                        thomas_id = "02128",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "33",
                        name = "Waxman, Henry A.",
                        sponsored_at = "2014-02-06",
                        state = "CA",
                        thomas_id = "01209",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "3",
                        name = "Westmoreland, Lynn A.",
                        sponsored_at = "2014-03-05",
                        state = "GA",
                        thomas_id = "01779",
                        title = "Rep",
                        withdrawn_at = null
                    },
                    new CongressContainer.Cosponsor
                    {
                        district = "1",
                        name = "Whitfield, Ed",
                        sponsored_at = "2014-03-05",
                        state = "KY",
                        thomas_id = "01222",
                        title = "Rep",
                        withdrawn_at = null
                    }
                },
                history = new CongressContainer.History
                {
                    active = true,
                    active_at = "2014-03-12T19:24:00-04:00",
                    awaiting_signature = false,
                    enacted = false,
                    house_passage_result = "pass",
                    house_passage_result_at = "2014-03-14T11:16:00-04:00",
                    vetoed = false
                },
                related_bills = new[]
                {
                    new CongressContainer.Bill
                    {
                        bill_id = "hres515-113",
                        reason = "rule",
                        type = "bill"
                    },
                    new CongressContainer.Bill
                    {
                        bill_id = "hr2810-113",
                        reason = "related",
                        type = "bill"
                    },
                    new CongressContainer.Bill
                    {
                        bill_id = "hr4209-113",
                        reason = "related",
                        type = "bill"
                    },
                    new CongressContainer.Bill
                    {
                        bill_id = "hr4418-113",
                        reason = "related",
                        type = "bill"
                    },
                    new CongressContainer.Bill
                    {
                        bill_id = "hr4750-113",
                        reason = "related",
                        type = "bill"
                    },
                    new CongressContainer.Bill
                    {
                        bill_id = "s1769-113",
                        reason = "related",
                        type = "bill"
                    },
                    new CongressContainer.Bill
                    {
                        bill_id = "s1871-113",
                        reason = "related",
                        type = "bill"
                    },
                    new CongressContainer.Bill
                    {
                        bill_id = "s2000-113",
                        reason = "identical",
                        type = "bill"
                    },
                    new CongressContainer.Bill
                    {
                        bill_id = "s2110-113",
                        reason = "related",
                        type = "bill"
                    },
                    new CongressContainer.Bill
                    {
                        bill_id = "s2122-113",
                        reason = "related",
                        type = "bill"
                    },
                    new CongressContainer.Bill
                    {
                        bill_id = "s2157-113",
                        reason = "related",
                        type = "bill"
                    }
                },
                sponsor = new CongressContainer.Sponsor
                {
                    district = "26",
                    name = "Burgess, Michael C.",
                    state = "TX",
                    thomas_id = "01751",
                    title = "Rep",
                    type = "person"
                },
                subjects = new[]
                {
                    "Advisory bodies",
                    "Congressional oversight",
                    "Fraud offenses and financial crimes",
                    "Government information and archives",
                    "Government studies and investigations",
                    "Government trust funds",
                    "Health",
                    "Health care coverage and access",
                    "Health care quality",
                    "Health information and medical records",
                    "Health personnel",
                    "Hospital care",
                    "Medicare",
                    "Minority health",
                    "Performance measurement",
                    "Rural conditions and development"
                },
                summary = new CongressContainer.Summary
                {
                    @as = "Passed House amended",
                    date = "2014-03-14",
                    text = "SGR Repeal and Medicare Provider Payment Modernization Act of 2014 - (Sec. 2) Amends part B (Supplementary Medical Insurance) of title XVIII (Medicare) of the Social Security Act (SSA) to: (1) end with 2013 the current formula for an update to the single conversion factor in the formula for payment for physicians' services, (2) end and remove sustainable growth rate (SGR) methodology from the determination of such annual conversion factors, (3) prescribe an update to the single conversion factor for 2014-2018 of 0.5%, (4) freeze the update to the single conversion factor at 0.00% for 2019-2023, and (5) establish for 2024 and subsequent years an update of 1% for health professionals participating in alternative payment models (APMs) and an update of 0.5% for all other health professionals.\n\nDirects the Medicare Payment Advisory Commission (MEDPAC) to report to Congress on the relationship between: (1) physician and other health professional utilization and expenditures (and their rates of increase) of items and services for which Medicare payment is made, and (2) total utilization and expenditures (and their rate of increase) under Medicare parts A (Hospital Insurance), B, and D (Voluntary Prescription Drug Benefit Program).\n\nDirects MEDPAC to report to Congress on: (1) the payment update for professional services applied for 2014-2018; (2) the effect of that update on the efficiency, economy, and quality of care; (3) the update's effect on ensuring a sufficient number of providers to maintain access to care by Medicare beneficiaries; and (4) recommendations for any future payment updates to ensure adequate access to care is maintained for such beneficiaries.\n\nDirects the Secretary of Health and Human Services (HHS) to establish a merit-based incentive payment system (MIPS) by consolidating (with certain revisions) the existing: (1) electronic health record (EHR) meaningful use incentive program, (2) quality reporting program, and (3) value-based payment program.\n\n Applies the MIPS program to payments for items and services furnished on or after January 1, 2018.\n\nRequires MIPS-eligible professionals (excluding most APM participants) to receive annual payment increases or decreases based on their performance.\n\nDefines MIPS-eligible professional as: (1) a physician, a physician assistant, nurse practitioner, clinical nurse specialist, and a certified registered nurse anesthetist during the MIPS program's first two years, and (2) also other eligible professionals specified by the Secretary for succeeding years.\n\n Excludes from treatment as a MIPS eligible professional any eligible professional who is: (1) a qualifying APM participant; (2) a partial qualifying APM participant for the most recent period for which data are available and who, for the performance period with respect to that year, does not report on applicable measures and activities a MIPS professional is required to report; or (3) does not exceed, for that performance period, a specified low-volume threshold measurement.\n\nQualifies for MIPS incentive payments a partial qualifying APM participant who reports on applicable measures and activities a MIPS professional is required to report.\n\nPrescribes requirements for: (1) application of the MIPS program to group practices; and (2) measures and activities under the performance categories of quality, resource use, clinical practice improvement, and meaningful use of EHR technology.\n\nRequires the Secretary, on an ongoing basis, to: (1) estimate how an individual's health status and other risk factors affect quality and resource use outcome measures; (2) incorporate information from quality and resource use outcome measurements (including care episode and patient condition groups) into the MIPS; and (3) account for identified factors with an effect on those measures when determining payment adjustments, composite performance scores, scores for performance categories, or scores for measures or activities under the MIPS. Requires the Secretary to: (1) establish performance standards for the MIPS program, taking into account historical performance standards, improvement rates, and the opportunity for continued improvement; and (2) develop a methodology for assessing the total performance of each MIPS eligible professional according to such standards with respect to applicable measures and activities for each performance category, leading to a composite performance score for each professional for each performance period.\n\nDirects the Secretary to specify a MIPS adjustment factor for each MIPS eligible professional for a year according to a formula taking into account composite performance scores above or below a performance threshold, including those at or above an additional performance threshold (for exceptional performance).\n\nMakes appropriations for 2018-2023 from the Federal Supplementary Medical Insurance Trust Fund for MIPS payments resulting from additional MIPS adjustment factors.\n\nPrescribes a formula for the calculation of MIPS program incentive payments, beginning with 2018, subject to criteria for budget neutrality as well as a process for review of the calculation of an individual professional's MIPS program incentive payment adjustment factor for a year.\n\nDirects the Secretary to make available on the Physician Compare website of the Centers for Medicare & Medicaid Services (CMS) certain information, including information regarding the performance of MIPS-eligible professionals.\n\nDirects the Secretary to enter into contracts or agreements with appropriate entities (such as quality improvement organizations, regional extension centers, or regional health collaboratives) to offer guidance and assistance about performance categories or transition to an APM to MIPS-eligible professionals in practices of 15 or fewer professionals (with priority given to practices located in rural areas, health professional shortage areas, medically underserved areas, and practices with low composite performance scores).\n\nRequires the Secretary to make available to each MIPS eligible professional timely (such as quarterly) confidential feedback and other information to improve performance.\n\nRequires the Comptroller General (GAO) to: (1) evaluate the MIPS program; and (2) report on the similarities and differences in the use of quality measures under the original Medicare fee-for-service program, the Medicare Advantage program under Medicare part C (Medicare+Choice), selected state medical assistance programs under SSA title XIX (Medicaid), and private payer arrangements, and make recommendations on how to reduce the administrative burden involved in applying such quality measures.\n\nDirects GAO to examine: (1) whether entities that pool financial risk for physician services (such as independent risk managers) can play a role in supporting physician practices in assuming financial risk for treatment of patients; and (2) the transition to an APM of professionals in rural areas, health professional shortage areas, or medically underserved areas.\n\nEstablishes the Payment Model Technical Advisory Committee to make recommendations to the Secretary on physician-focused payment models.\n\nPrescribes incentive payments for participation in eligible APMs between 2018 and 2023, consisting of an additional 5% of the current-year payment amount for the covered professional services for the preceding year.\n\nProhibits any construction of this Act to preclude an APM or a qualifying APM participant from furnishing a telehealth service for which Medicare payment is not made.\n\nDirects the Secretary to study: (1) the feasibility of integrating APMs in the Medicare Advantage payment system, (2) the applicability of federal fraud prevention laws to items and services furnished under Medicare for which payment is made under an APM, (2) aspects of such APMs that are vulnerable to fraudulent activity, and (3) the implication of waivers to such laws granted in support of such APMs.\n\nRequires the Secretary to study: (1) the effect of individuals' socioeconomic status on quality and resource use outcome measures for individuals under Medicare; and (2) the impact of certain risk factors, race, health literacy, limited English proficiency (LEP), and patient activation on quality and resource use outcome measures under Medicare.\n\nDirects the Secretary, taking account of such studies, to: (1) estimate how an individual's health status and other risk factors affect quality and resource use outcome measures and, as feasible, to incorporate information from quality and resource use outcome measurement into the eligible professional MIPS incentive program; and (2) account for other identified factors with an effect on quality and resource use outcome measures when determining payment adjustments under the MIPS incentive program.\n\nDirects the Secretary to develop and report to Congress on a strategic plan for collecting or otherwise assessing data on race and ethnicity for purposes of carrying out the eligible professional MIPS incentive program.\n\nDirects the Secretary to take certain steps, including development of care episode and patient condition groups as well as proposed classification codes, in order to involve the physician, practitioner, and other stakeholder communities in enhancing the infrastructure for resource use measurement for MIPS, APM, and other purposes.\n\n Prohibits the Secretary from contracting with an entity, or an entity from subcontracting with another entity, if either the contracting or the subcontracting entity currently makes recommendations to the Secretary on relative values for physicians' services under the fee schedule. (Sec. 3) Directs the Secretary to develop and post on the Internet website of the Centers for Medicare and Medicaid Services (CMS) a draft plan as well as an operational plan, taking stakeholder comments on the draft plan into account, for the development of quality measures to assess professionals.\n\nDirects the Secretary to enter into contracts or other arrangements with entities, including those organizations with quality measure development expertise, for the purpose of developing, improving, updating, or expanding such quality measures.\n\nRequires the Secretary to transfer $15 million from the Federal Supplemental Medical Insurance Trust Fund to the CMS Program Management Account for each of FY2014-2018.\n\n(Sec. 4) Requires the Secretary to: (1) establish one or more Healthcare Common Procedure Coding System (HCPCS) codes for chronic care management services for patients with chronic care needs, (2) make payments for any such services furnished by an applicable provider, and (3) conduct an education and outreach campaign to inform professionals who furnish items and services under Medicare part B and Medicare part B enrollees of the benefits of chronic care management services.\n\n(Sec. 5) Authorizes the Secretary to: (1) collect or obtain information from any eligible professional or any other source on the resources directly or indirectly related to furnishing services paid for under the Medicare fee schedule, and (2) use such information to determine relative values for those services.\n\nAuthorizes the Secretary to establish or adjust practice expense relative values using cost, charge, or other data from suppliers or service providers, including any such collected or obtained information.\n\nExpands the list of codes the Secretary must examine to identify services that may be misvalued, including codes: (1) that account for the majority of spending under the physician fee schedule, (2) that have experienced a substantial change in the hospital length of stay or procedure time, (3) for which there is a significant difference in payment for the same service between different sites of service, (4) with high intra-service work per unit of time, (5) with high practice expense relative value units (RVUs), and (6) with high cost supplies.\n\nSets at 0.5% of the estimated amount of fee schedule expenditures in 2015-2018 the annual target (estimated net reduction in expenditures under the fee schedule) with respect to relative value adjustments for misvalued services.\n\nDeclares that, for fee schedules beginning with 2015, if the RVUs for a service for a year would otherwise be decreased by an estimated 20% or more as compared to the total RVUs for the previous year, the applicable adjustments in work, practice expense, and malpractice RVUs must be phased-in over a two-year period.\n\nDirects GAO to study the processes used by the Relative Value Scale Update Committee (RUC) (of the American Medical Association) to make recommendations to the Secretary regarding relative values for specific services.\n\nRequires the use on or after January 1, 2017, of metropolitan statistical areas (MSAs) as fee schedule areas in California, with all areas not included in an MSA to be treated as a single rest-of-state fee schedule area.\n\nPrescribes a formula for the geographic index values applied to the physicians fee schedule for MSAs previously in the rest-of-payment locality or in locality 3.\n\n Directs the Secretary to make publicly available the information used to establish the multiple procedure payment reduction policy to the professional component of imaging services in a specified final rule under the physicians fee schedule.\n\n(Sec. 6) Directs the Secretary to: (1) establish a program to promote the use of appropriate use criteria for certain advanced diagnostic imaging services furnished by ordering and furnishing professionals, and (2) specify applicable appropriate use criteria for imaging services from among appropriate use criteria developed or endorsed by national professional medical specialty societies or other entities.\n\nDirects the Secretary to: (1) determine, on a periodic basis, outlier ordering professionals; and (2) apply prior authorization for applicable imaging services ordered by an outlier ordering professional.\n\nProhibits the construction of these requirements as authorizing the Secretary to develop or initiate the development of clinical practice guidelines or appropriate use criteria.\n\n(Sec. 7) Requires the Secretary to make publicly available on the CMS Physician Compare website specified information with respect to eligible professionals.\n\n(Sec. 8) Allows a qualified entity, beginning July 1, 2015, to use Medicare claims data combined with data from sources other than claims data, as well as information derived from a specified performance evaluation of service providers and suppliers, to: (1) conduct additional appropriate non-public analyses; and (2) provide or sell them (subject to certain conditions) to physicians, other professionals, providers, medical societies, and hospital associations and certain other entities for non-public use. Prohibits any use of an analysis or data for marketing purposes.\n\nExpands the kinds (including standardized extracts) and uses of claims data available to qualified entities for quality improvement activities.\n\nLimits the provision or sale of such analyses to: (1) an employer solely for the purposes of providing health insurance to its employees and retirees, and (2) a health insurance issuer only if the issuer is providing the qualified entity offering the analyses with Medicare claims data combined with data from sources other than claims data.\n\nRequires a qualified entity and an authorized user that is a service provider, supplier, or medical society or hospital association to enter into an agreement regarding the use of any data that the qualified entity is providing to or selling the user, including privacy and data security requirements and any prohibitions on using such data to link to other individually identifiable sources of information. Requires the Secretary to: (1) impose a specified administrative assessment for any breach of such an agreement by a qualified entity, and (2) deposit assessment amounts into the Federal Supplementary Medical Insurance Trust Fund. Prohibits authorized users from redisclosing (except for performance improvement and care coordination activities) or making public any analysis, data, or analysis using data they have obtained or bought. Requires any fees charged for making standardized extracts of claims data available to qualified entities to be deposited into the CMS Program Management Account (currently, into the Federal Supplementary Medical Insurance Trust Fund). Directs the Secretary to provide Medicare claims data, and if appropriate also data under Medicaid and SSA title XXI (Children's Health Insurance Program) (CHIP), to requesting qualified clinical data registries in order to link such data with clinical outcomes data and perform risk-adjusted, scientifically valid analyses and research to support quality improvement or patient safety. Limits fees charged for such data to the cost of providing it, and requires their deposit into the CMS Program Management Account.\n\nRequires any fees charged for making standardized extracts of claims data available to qualified entities to be deposited into the CMS Program Management Account (currently, into the Federal Supplementary Medical Insurance Trust Fund).\n\n(Sec. 9) Permits continuing automatic extensions of a Medicare physician and practitioner election to opt-out of the Medicare physician payment system into private contracts.\n\nDirects the Secretary to make publicly available through an appropriate publicly accessible website information on the number and characteristics of opt-out physicians and practitioners.\n\nDirects the Secretary to make recommendations to Congress to amend existing fraud and abuse law to permit gainsharing or similar arrangements between physicians and hospitals that improve care while reducing waste and increasing efficiency.\n\nDeclares it a national objective to achieve widespread and nationwide exchange of health information through interoperable certified EHR technology by December 31, 2017, as a consequence of a significant federal investment in the implementation of health information technology through the Medicare and Medicaid EHR incentive programs.\n\nDirects the Secretary to study the feasibility of establishing mechanisms to compare certified EHR technology products.\n\n(Sec. 10) Amends the Internal Revenue Code to delay until January 1, 2019, implementation of the penalty for failure to comply with the individual health insurance mandate under the Patient Protection and Affordable Care Act to maintain minimum essential health care coverage."
                },
                titles = new[]
                {
                    new CongressContainer.Title
                    {
                        @as = "introduced",
                        is_for_portion = false,
                        title = "SGR Repeal and Medicare Provider Payment Modernization Act of 2014",
                        type = "short"
                    },
                    new CongressContainer.Title
                    {
                        @as = "passed house",
                        is_for_portion = false,
                        title = "SGR Repeal and Medicare Provider Payment Modernization Act of 2014",
                        type = "short"
                    },
                    new CongressContainer.Title
                    {
                        @as = "introduced",
                        is_for_portion = false,
                        title = "To amend title XVIII of the Social Security Act to repeal the Medicare sustainable growth rate and improve Medicare payments for physicians and other professionals, and for other purposes.",
                        type = "official"
                    }
                }
            };
        }
    }
}