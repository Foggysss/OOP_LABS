using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task3;
public class Task
{
    public void DoTask3()
    {
        TreeNode parent = new TreeNode(1);
        TreeNode child1 = new TreeNode(2);
        TreeNode child2 = new TreeNode(3);
        TreeNode grandchild1 = new TreeNode(4);
        TreeNode grandchild2 = new TreeNode(5);

        parent.AddChild(child1);
        parent.AddChild(child2);
        child1.AddChild(grandchild1);
        child1.AddChild(grandchild2);

        parent.PrintChildrenValues();
    }
}
