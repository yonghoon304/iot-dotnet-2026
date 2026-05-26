using System;

using System.Collections;

namespace Prac04Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 배열 초기화
            int[] array1 = new int[5];
            array1[0] = 1;
            array1[1] = 2;
            array1[2] = 3;
            array1[3] = 4;
            array1[4] = 5;

            Console.WriteLine(array1);

            // 배열 출력
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i]+" ");
            }
            Console.WriteLine();

            // foreach 사용
            foreach(var item in array1)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();

            // 컬렉션
            ArrayList al1 = new ArrayList(); // 컬렉션은 사이즈 지정 안해도 됨

            // add() 메서드로 데이터 추가
            al1.Add(1);
            al1.Add("Hello");
            al1.Add(3.14);
            al1.Add(true);  // Pythonㅓ처럼 타입제약없이 입력가능

            foreach(var item in al1)
            {
                Console.WriteLine(item);
            }
            // Stack ,Queue,Hash,List
            Hashtable ht1 = new Hashtable();
            ht1["apple"]= "사과";
            ht1["banana"] = "바나나";
            ht1["mango"] = "망고";

            Console.WriteLine(ht1["mango"]);

            Dictionary<String, String> ht2 = new Dictionary<String, String>();
            ht2["apple"] = "사과";

            Console.WriteLine(ht2["apple"]);

        }
    }
}
