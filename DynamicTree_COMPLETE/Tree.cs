using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DynamicTree_STARTER
{
	/// <summary>
	/// Represents a tree-centric data structure
	/// that can have data dynamically inserted
	/// </summary>
	class Tree
	{
		/// <summary>
		/// Gets the root node of the tree
		/// </summary>
		public TreeNode Root { get; private set; }

		/// <summary>
		/// Creates a simple binary tree
		/// </summary>
		public Tree()
		{
			// No data yet
			Root = null;
		}

		/// <summary>
		/// Public facing Insert method
		/// </summary>
		/// <param name="data">The data to insert</param>
		public void Insert(int data)
		{
			// *** Fill in this method *************************************
			if (Root == null)
			{
				Root = new TreeNode(data);
			}
			else
			{
				Insert(data, Root);
			}


			// *************************************************************
		}

		/// <summary>
		/// Private recursive Insert method
		/// </summary>
		/// <param name="data">The data to insert</param>
		/// <param name="node">The node to attempt to insert into</param>
		private void Insert(int data, TreeNode node)
		{
			// *** Fill in this method *************************************
			if (data < node.Data)
			{
				if (node.Left == null) node.Left = new TreeNode(data);
				else Insert(data, node.Left);
			}
			else
			{
				if (node.Right == null) node.Right = new TreeNode(data);
				else Insert(data, node.Right);
			}

			// *************************************************************
		}

		public void Remove(int data)
		{
			// Start at the root
			Root = Remove(data, Root);
		}

		private TreeNode Remove(int data, TreeNode currentNode)
		{
			if (currentNode == null)
				return null;

			// Determine which way
			if (data < currentNode.Data)
				currentNode.Left = Remove(data, currentNode.Left);
			else if (data > currentNode.Data)
				currentNode.Right = Remove(data, currentNode.Right);
			else // data == currentNode.Data
			{
				// Check the status of current node
				if (currentNode.Left == null && currentNode.Right == null)
				{
					// Leaf node, so it should be removed
					return null;
				}
				else if (currentNode.Left != null && currentNode.Right != null)
				{
					// Two children, so get a valid replacement
					// (the min of the right child) and swap
					TreeNode swap = GetMinNode(currentNode.Right);
					currentNode.Data = swap.Data;
					currentNode.Right = Remove(swap.Data, currentNode.Right);
				}
				else if (currentNode.Left != null)
				{
					// One child, to the left
					return currentNode.Left;

				}
				else if (currentNode.Right != null)
				{
					// One child, to the right
					return currentNode.Right;
				}
			}

			return currentNode;
		}

		private TreeNode GetMinNode(TreeNode node)
		{
			if (node.Left != null)
				return GetMinNode(node.Left);

			return node;
		}
    }
}
