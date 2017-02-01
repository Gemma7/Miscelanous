using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomSequenceOperators.Classes
{
    public class LinqSamples
    {
        private DataSet testDs;

        public LinqSamples()
        {
            testDs = TestHelper.CreateTestDataset();
        }

        [Category("Custom Sequence Operators")]
        [Description("This sample uses a user-created sequence operator, Combine, to calculate the " +
                     "dot product of two vectors.")]
        public void DataSetLinq98()
        {
            var numbersA = testDs.Tables["NumbersA"].AsEnumerable();
            var numbersB = testDs.Tables["NumbersB"].AsEnumerable();

            var dotProduct = numbersA.Combine(numbersB, 
                                              (a, b) => a.Field<int>("number") * b.Field<int>("number")).Sum();

            Console.WriteLine("Dot product: {0}", dotProduct);
        }
    }
}
