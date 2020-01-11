namespace algoexpert
{
// ​Validate BST

// You are given a Binary Tree data structure consisting of Binary Tree nodes.Each Binary Tree node has an integer 
// \value stored in a property called "value" and two children nodes stored in properties called "left" and "right," 
// respectively.Children nodes can either be Binary Tree nodes themselves or the None(null) value.Write a function 
// that returns a boolean representing whether or not the Binary Tree is a valid BST.A node is said to be a BST node 
// if and only if it satisfies the BST property: its value is strictly greater than the values of every node to its 
// left; its value is less than or equal to the values of every node to its right; and both of its children nodes 
// are either BST nodes themselves or None(null) values.

// Sample input:
//             10
//           /       \
//         5         15
//       /    \     /      \
//     2      5 13     22
//   /                  \
// 1                    14
// Sample output: True

using System;
public partial class Program
    {
        // O(n) time | O(d) space
        public static bool ValidateBst(ValidateBST tree)
        {
            return ValidateBst(tree, Int32.MinValue, Int32.MaxValue);
        }

        public static bool ValidateBst(ValidateBST tree, int minValue, int maxValue)
        {
            if (tree.value < minValue || tree.value >= maxValue)
            {
                return false;
            }
            if (tree.left != null && !ValidateBst(tree.left, minValue, tree.value))
            {
                return false;
            }
            if (tree.right != null && !ValidateBst(tree.right, tree.value, maxValue))
            {
                return false;
            }
            return true;
        }

        public class ValidateBST
        {
            public int value;
            public ValidateBST left;
            public ValidateBST right;

            public ValidateBST(int value)
            {
                this.value = value;
            }
        }
    }
}