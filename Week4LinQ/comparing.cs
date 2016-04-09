//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace Week4LinQ
//{
//    class comparing : Program
//    {
//        public static int Compare<T>(this IEnumerable<T> rollValue1, IEnumerable<T> rollValue2)
//        {
//            // If one of collection objects is null, use the default Comparer class
//            // (null is considered to be less than any other object)
//            if (rollValue1 == null || rollValue2 == null)
//                return System.Collections.Comparer.Default.Compare(rollValue1, rollValue2);

//            var elementComparer = Comparer<T>.Default;
//            int compareResult;

//            using (var firstEnum = rollValue1.GetEnumerator())
//            using (var secondEnum = rollValue2.GetEnumerator())
//            {
//                do
//                {
//                    bool gotFirst = firstEnum.MoveNext();
//                    bool gotSecond = secondEnum.MoveNext();

//                    // Reached the end of collections => assume equal
//                    if (!gotFirst && !gotSecond)
//                        return 0;

//                    // Different sizes => treat collection of larger size as "greater"
//                    if (gotFirst != gotSecond)
//                        return gotFirst ? 1 : -1;

//                    compareResult = elementComparer.Compare(firstEnum.Current, secondEnum.Current);
//                } while (compareResult == 0);
//            }

//            return compareResult;
//        }
//    }
//}
