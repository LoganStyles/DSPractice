public struct TestResult
{
    public bool succeeded;
    public string reason;
    public string input;
    public int[] expected_output;
    public int[]  actual_output;
}