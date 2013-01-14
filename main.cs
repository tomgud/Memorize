using System;

namespace Memorize {
    public class Runner {

        static void Main(String[] args) {

            Memo m1 = new Memo("Title3", "Content1");
            Memo m2 = new Memo("Title2", "Content2");
            Memo m3 = new Memo("Title1", "Content3");

            MemoList ml1 = new MemoList();
            MemoList ml2 = new MemoList();

            ml1.AddMemo(m1);
            ml1.AddMemo(m2);
            ml2.AddMemo(m3);

            ml1.AddList(ml2);
            Console.WriteLine("MemoList one :");
            foreach (Memo item in ml1) 
            {
                Console.WriteLine(item.ToString());
            }

            ml2.AddList(ml1);
            ml2.Sort(MemoList.MemoListSortingEnumerator.Title);
            Console.WriteLine("MemoList two :");
            foreach (Memo item in ml2) 
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
