using System;
using Memorize.Items;

namespace Memorize {
    public class Runner {

        static void Main(String[] args) {

            Memo m1 = new Memo("Title3", "Content1");
            Memo m2 = new Memo("Title2", "Content2");
            Memo m3 = new Memo("Title1", "Content3");

            MemoList ml1 = new MemoList();
            ml1.SetTitle("MemoList1");
            MemoList ml2 = new MemoList();
            ml1.SetTitle("MemoList2");

            ml1.Add(m1);
            ml1.Add(m2);
            ml2.Add(m3);

            ml1.Add(ml2);
            Console.WriteLine(ml1.ToString());
            ml2.Add(ml1);
            ml2.Sort(MemoList.MemoListSortingEnumeration.Title);
            Console.WriteLine(ml2.ToString());
        }
    }
}
