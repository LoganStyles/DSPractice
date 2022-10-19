public static class IntersectTestRunner
{

    public static TestResult[] executeTests()
    {

        List<int[]> input1 = new List<int[]>{
            new int[]{10, 11, 11, 22, 30, 40 }, new int[]{10, 16, 11, 12, 30, 50,30, 56 },
            };

        List<int[]> input2 = new List<int[]>{
            new int[]{-10, 11, -12 }, new int[]{-10, 16, 11, -12, 30, 12,30, 56 }
            };

        List<int[]> input3 = new List<int[]>{
            new int[]{0, 0, 0, 0, 0, 0 }, new int[]{0, 0, 0, 0, 0, 0, 0 }
            };

        List<int[]> input4 = new List<int[]> { new int[] { }, new int[] { } };

        List<int[]> input5 = new List<int[]> { new int[] { 10 }, new int[] { } };

        List<List<int[]>> inputs = new List<List<int[]>>();
        inputs.Add(input1);
        inputs.Add(input2);
        inputs.Add(input3);
        inputs.Add(input4);
        inputs.Add(input5);

        List<int[]> expected_outputs = new List<int[]> {
            new int[]{10, 11,30 },
            new int[]{-10, 11,-12 },
            new int[]{0},
            new int[]{},
            new int[]{}
        };
        TestResult[] test_results = new TestResult[5];

        for (int i = 0; i < inputs.Count; i++)
        {
            test_results[i] = new TestResult();
            test_results[i].input = "Intersect(" + inputs[i][0].ToString() + "," + inputs[i][1].ToString() + ")";
            test_results[i].expected_output = expected_outputs[i];

            int[] actual_output = MyArray.IntersectUsingASet(inputs[i][0], inputs[i][1]);
            // int[] actual_output = MyArray.IntersectUsingAList(inputs[i][0], inputs[i][1]);
            // int[] actual_output = MyArray.Intersect(inputs[i][0], inputs[i][1]);
            test_results[i].actual_output = actual_output;

            if (actual_output.SequenceEqual(expected_outputs[i]))
            {
                test_results[i].reason = "Succeeded";
                test_results[i].succeeded = true;
            }
            else
            {
                test_results[i].reason = "Incorrect output";
                test_results[i].succeeded = false;
            }
        }

        return test_results;

    }

    // public static bool IsEqual(int[] array1, int[] array2)
    // {
    //     return array1.SequenceEqual(array2);
    //     // bool result = true;
    //     // HashSet<int> set = new HashSet<int>();

    //     // if (array1.Length != array2.Length)
    //     //     return false;

    //     // foreach (var item in array1)
    //     //     set.Add(item);

    //     // return true;
    // }
}