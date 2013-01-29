using System;
using Memorize.Items;

namespace Memorize {
    public class Runner {

        static void Main(String[] args) {

            Memo m1 = new Memo("NTitle3", "Content1");
            m1.AddAttribute(new DateAttribute(new DateTime(2013, 6, 6)));
            TagAttribute tag = new TagAttribute("Project");
            tag.Name = "ASDF";
            tag.Value = "Purject";
            m1.AddAttribute(tag);
            tag = new TagAttribute();
            tag.Value = "Assignment";
            m1.AddAttribute(tag);
            tag.Value = " ASSHOLE ";
            m1.AddAttribute(new TagAttribute("Bug"));

            Memo m2 = new Memo("ATitle2", "Content2");
            m2.AddAttribute(new TagAttribute("Goal"));
            
            Memo m3 = new Memo("AATitle1", "Content3");
            m2.AddAttribute(new TagAttribute("Project"));
            m3.AddAttribute(new TagAttribute("Bug"));

            MemoList ml1 = new MemoList();
            ml1.SetTitle("MemoList1");
            MemoList ml2 = new MemoList();
            ml2.SetTitle("MemoList2");

            ml1.Add(m1);
            ml1.Add(m2);
            ml2.Add(m3);

            ml1.Sort(MemoList.MemoListSortingEnumeration.Title);
            Console.WriteLine(ml1.ToString());
            Console.WriteLine(ml2.ToString());
        }
    }
}
