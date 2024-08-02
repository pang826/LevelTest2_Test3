namespace Test3
{
    //    배열 arr가 주어집니다.배열 arr의 각 원소는 숫자 0부터 9까지로 이루어져 있습니다.
    //이때, 배열 arr에서 연속적으로 나타나는 숫자는 하나만 남기고 전부 제거하려고 합니다.
    //단, 제거된 후 남은 수들을 반환할 때는 배열 arr의 원소들의 순서를 유지해야 합니다.
    //예를들면,
    // - arr = [1, 1, 3, 3, 0, 1, 1] 이면[1, 3, 0, 1] 을 return 합니다.
    // - arr = [4, 4, 4, 3, 3] 이면[4, 3] 을 return 합니다.

    //배열 arr에서 연속적으로 나타나는 숫자는 제거하고 남은 수들을 return하는 solution 함수를 완성해주세요.

    // - 배열 arr의 크기 : 1,000,000 이하의 자연수
    // - 배열 arr의 원소의 크기 : 0보다 크거나 같고 9보다 작거나 같은 정수

    internal class Program
    {
        static public List<int> Solution(List<int> array)
        {
            List<int> answer = new List<int>();
            answer.Add(array.First()); // 첫번째 값은 무조건 들어가게 함으로써 for 반복문으로 첫번째 값 중복시 입력이 안되는 문제 해결
            for (int i = 1; i < array.Count; i++)
            {
                if (array[i] != array[i - 1]) // i를 1부터 반복하도록 하고 i-1과 비교하도록 하여 i+1로 했을 시 발생하는 예외처리 문제 해결(+ 첫번째 값은 위에서 미리 입력했기 때문에 1부터 반복 시작)
                {
                    answer.Add(array[i]);
                }
            }
            return answer;
        }
        static void Main(string[] args)
        {
            List<int> array = new List<int> {4,4,4,3,3};
 
            
            List<int> result = Solution(array);

            foreach(int i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
