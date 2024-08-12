namespace UnionArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] myArray2 = { 2, 3, 4, 4, 5, 11, 12 };
            Console.WriteLine("Array1");
            PrintArrays(myArray1);
            Console.WriteLine("Array2");
            PrintArrays(myArray2);
            Console.WriteLine("Union of Arrays");
            PrintArrays(UnionArrays2(myArray1, myArray2, myArray1.Length, myArray2.Length).ToArray());

            //PrintArrays(FindUnion(myArray1 , myArray2, myArray1.Length, myArray2.Length).ToArray());
        }

        static List<int> FindUnion(int[] arr1, int[] arr2, int n, int m)
        {
            int i = 0, j = 0;
            List<int> Union = new List<int>();

            while (i < n && j < m)
            {
                if (arr1[i] <= arr2[j])
                {
                    if (Union.Count == 0 || Union[Union.Count - 1] != arr1[i])
                        Union.Add(arr1[i]);
                    i++;
                }
                else
                {
                    if (Union.Count == 0 || Union[Union.Count - 1] != arr2[j])
                        Union.Add(arr2[j]);
                    j++;
                }
            }

            while (i < n)
            {
                if (Union[Union.Count - 1] != arr1[i])
                    Union.Add(arr1[i]);
                i++;
            }

            while (j < m)
            {
                if (Union[Union.Count - 1] != arr2[j])
                    Union.Add(arr2[j]);
                j++;
            }

            return Union;
        }

        static List<int> UnionArrays2(int[] a, int[] b, int n1, int n2)
        {
            List<int> ls = new List<int>();
            int i = 0;
            int j = 0;
            //int n1 = a.Length;
            //int n2 = b.Length;

            while(i < n1 && j < n2) 
            {
                if (a[i] <= b[j])
                {
                    if(ls.Count == 0 || ls[ls.Count -1] != a[i])
                    {
                        ls.Add(a[i]);
                    }
                    i++;
                }
                else
                {
                    if (ls.Count == 0 || ls[ls.Count - 1] != b[j])
                    {
                        ls.Add(b[j]);
                    }
                    j++;
                }
            }

            while(i < n1)
            {
                if (ls.Count == 0 || ls[ls.Count - 1] != a[i])
                {
                    ls.Add(a[i]);
                }
                i++;
            }

            while(j < n2)
            {
                if (ls.Count == 0 || ls[ls.Count - 1] != b[j])
                {
                    ls.Add(b[j]);
                }
                j++;
            }

            return ls;

        }

        static int[] UnionArray1(int[] a, int[] b)
        {
            HashSet<int> hs = new HashSet<int> { };

            for(int i = 0; i< a.Length; i++)
            {
                hs.Add(a[i]);
            }
            for(int i = 0; i < b.Length; i++)
            {
                hs.Add(b[i]);
            }

            int[] returnArray = new int[hs.Count];

            int j = 0;
            foreach(int i in hs)
            {
                returnArray[j] = i;
                j++;
            }

            return returnArray;
        }

        static void PrintArrays(int[] a)
        {
            for(int i = 0; i < a.Length;  i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}