using static LINQBasic01.ListGenerator;
namespace LINQBasic01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Restriction Operators

            #region 1

            var OutOfStock = ProductsList.Where(P => P.UnitsInStock == 0);

            foreach (var Product in OutOfStock)
            {
                Console.WriteLine(Product);
            }
            #endregion

            Console.WriteLine("**********************************************************");
            #region 2

            var InStock = ProductsList.Where(P => P.UnitsInStock != 0 && P.UnitPrice > 3);

            foreach (var Product in InStock)
            {
                Console.WriteLine(Product);
            }
            #endregion

            Console.WriteLine("**********************************************************");
            #region 3

            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var result = Arr.Where((A, Index) => A.Length < Index);


            foreach (var A in result)
            {
                Console.WriteLine(A);
            }


            #endregion

            Console.WriteLine("**********************************************************");
            #endregion

            #region Ordering Operators

            #region 1

            var SortProduct = ProductsList.OrderBy(P => P.ProductName);
            foreach (var A in SortProduct)
            {
                Console.WriteLine(A);
            }
            #endregion
            Console.WriteLine("**********************************************************");

            #region 2

            #endregion

            #region 3

            var sortUnitOfStock = ProductsList.OrderByDescending(P => P.UnitsInStock);
            foreach (var item in sortUnitOfStock)
            {
                Console.WriteLine(item);
            }

            #endregion
            Console.WriteLine("**********************************************************");

            #region 4

            string[] Arr1 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var SortArr = Arr1.OrderBy(A => A.Length).ThenBy(A => A);

            foreach (var A in SortArr)
                Console.WriteLine(A);

            #endregion
            Console.WriteLine("**********************************************************");

            #region 5
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var SortWords = words.OrderBy(W => W.Length).ThenBy(W => W.ToLower());
            foreach (var W in SortWords)
                Console.WriteLine(W);
            #endregion
            Console.WriteLine("**********************************************************");

            #region 6
            var ProductSorted = ProductsList.OrderBy(P => P.Category).ThenByDescending(P=> P.UnitPrice);
            foreach (var PS in ProductSorted)
                Console.WriteLine(PS);
            #endregion
            Console.WriteLine("**********************************************************");


            #region 7
            string[] Arr2 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var SortArr2 = Arr2.OrderBy(A => A.Length).ThenByDescending(A => A.ToLower());
            foreach(var SA in SortArr2)
                Console.WriteLine(SA);
            #endregion

            Console.WriteLine("**********************************************************");
            #region 8
            
            string[] Arr3 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var DigitList = Arr3.Where(A => A[1] == 'i').Reverse();

            foreach (var item in DigitList)
                Console.WriteLine(item);

            #endregion

            Console.WriteLine("**********************************************************");
            #endregion

        }
    }
}
