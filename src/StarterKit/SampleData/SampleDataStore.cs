using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StaterKit.Models;

namespace StaterKit
{
    public class SampleDataStore
    {
        public static SampleDataStore Sample {get;} = new SampleDataStore();
        public List<SampleModel> Name {get; set;}

        public SampleDataStore() 
        {
            Name = new List<SampleModel>()
            {
                new SampleModel()
                {
                    Name = "New York",
                },
                new SampleModel()
                {
                    Name = "America",
                },
                new SampleModel()
                {
                    Name = "Paris",
                }
            };
        }
    }
}