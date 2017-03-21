using System.Collections.Generic;

namespace Algorithm.BaseCollection.BinaryTree
{
    public class BinaryTree<T>
    {
        public BinaryNode<T> RootNode { get; }

        //public BinaryTree(ICollection<T> temp)
        //{
        //    int count;
        //    for (int i = 0; i < temp.Count; i++)
        //    {
        //        BinNode Node = new BinNode(temp[i]);

        //        sp.Add(Node);
        //    }
        //    count = temp.Count;
        //    for (int i = 0; i < count; i++)
        //    {
        //        try
        //        {
        //            sp[i].Node_left = temp[1];
        //            temp.RemoveAt(1);
        //            sp[i].Node_right = temp[1];
        //            temp.RemoveAt(1);
        //        }
        //        catch
        //        {

        //        }
        //    }
        //    for (int i = 0; i < sp.Count; i++)
        //    {
        //            for (int k = 0; k < sp.Count; k++)
        //            {
        //                if (sp[i].Node_left == sp[k].Getkey())
        //                {
        //                    sp[k].Node_up = sp[i].Getkey();
        //                }
        //                if (sp[i].Node_right == sp[k].Getkey())
        //                {
        //                    sp[k].Node_up = sp[i].Getkey();
        //                }
        //            }

        //    }
        //}
    }
}
