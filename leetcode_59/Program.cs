namespace leetcode_59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int[][] result = new Program().GenerateMatrix(n);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(String.Join(" ", result[i]));
            }

        }

        public int[][] GenerateMatrix(int n)
        {
            int[][] answer = new int[n][];
            for (int i = 0; i < n; i++)
            {
                answer[i] = new int[n];
            }
            int start = 0;
            int end = n - 1;
            int temp = 1;
            while (temp < n * n)
            {
                for (int i = start; i < end; i++)
                {
                    answer[start][i] = temp;
                    temp++;
                }
                for (int i = start; i < end; i++)
                {
                    answer[i][end] = temp;
                    temp++;
                }
                for (int i = end; i > start; i--)
                {
                    answer[end][i] = temp;
                    temp++;
                }
                for (int i = end; i > start; i--)
                {
                    answer[i][start] = temp;
                    temp++;
                }

                start++;
                end--;
            }
            if (n % 2 == 1) answer[n / 2][n / 2] = temp;
            return answer;

        }
    }

}