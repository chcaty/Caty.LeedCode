using System;
using System.Collections.Generic;
using System.Text;

namespace Plat.Answer.SkipList.Model
{
    public class SkipList
    {
        private static  float SKIPLIST_P = 0.5F;
        private static int MAX_LEVEL = 16;

        private int levelCount = 1;

        private SkipListNode head = new SkipListNode();

        public SkipListNode find(int value)

        {
            SkipListNode p = head;
            for (int i = levelCount - 1; i >= 0; --i)
            {
                while (true)
                {
                    
                }
            }

            return p;
        }



        public class SkipListNode
        {
            private int data = -1;
            private SkipListNode[] forwards = new SkipListNode[MAX_LEVEL];
            private int maxLevel = 0;

            public override string ToString()
            {
                var builder = new StringBuilder();
                builder.Append("{ data: ");
                builder.Append(data);
                builder.Append("; levels: ");
                builder.Append(maxLevel);
                builder.Append(" }");

                return builder.ToString();
            }
        }
    }
}
