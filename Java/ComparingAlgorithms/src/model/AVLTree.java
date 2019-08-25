package model;

import java.util.ArrayList;

public class AVLTree {

	private AVLNode root;

	public AVLTree() {
		root = null;
	}

	public AVLTree(AVLNode root) {
		this.root = root;
	}

	public AVLNode getRoot() {
		return root;
	}

	public int getMax() {

		AVLNode current = root;
		if (current == null) {
			return Integer.MAX_VALUE;
		}
		while (current.getRight() != null) {
			current = current.getRight();
		}
		return current.getValue();

	}

	public int getMin() {

		AVLNode current = root;
		if (current == null) {
			return Integer.MIN_VALUE;
		}
		while (current.getLeft() != null) {
			current = current.getLeft();
		}
		return current.getValue();

	}

	public void insert(int data) {

		root = insert(root, data);

	}

	private AVLNode insert(AVLNode node, int value) {

		if (node == null) {
			return new AVLNode(value, null, null);
		} else {
			if (node.compare(new AVLNode(value, null, null)) > 0) {
				node.setLeft(insert(node.getLeft(), value));
			} else {
				node.setRight(insert(node.getRight(), value));
			}
			node.setHeight(Math.max(height(node.getLeft()), height(node.getRight())) + 1);
			int balanceFactor = balanceFactor(node);
			if (balanceFactor < -1) {
				if (balanceFactor(node.getRight()) > 0) {
					node.setRight(rotateRight(node.getRight()));
					return rotateLeft(node);
				} else {
					return rotateLeft(node);
				}
			} else if (balanceFactor > 1) {
				if (balanceFactor(node.getLeft()) < 0) {
					node.setLeft(rotateLeft(node.getLeft()));
					return rotateRight(node);
				} else {
					return rotateRight(node);
				}
			}
		}
		return node;

	}

	public void delete(AVLNode root, int value) {

		root = deleteR(root, value);

	}

	public AVLNode deleteR(AVLNode root, int value) {

		if (root == null) {
			return root;
		}
		AVLNode toCompare = new AVLNode(value, null, null);
		if (toCompare.compare(root) < 0) {
			root.setLeft(deleteR(root.getLeft(), value));
		} else if (toCompare.compare(root) > 0) {
			root.setRight(deleteR(root.getRight(), value));
		} else {

			if (root.getLeft() == null || root.getRight() == null) {

				AVLNode temp = null;
				if (temp == root.getLeft()) {
					temp = root.getRight();
				} else {
					temp = root.getLeft();
				}

				if (temp == null) {
					temp = root;
					root = null;
				} else {
					root = temp;
				}

			} else {
				AVLNode temp = minValueNode(root.getRight());
				root.setValue(temp.getValue());
				root.setRight(deleteR(root.getRight(), temp.getValue()));
			}

		}

		if (root == null) {
			return root;
		}
		root.setHeight(Math.max(height(root.getLeft()), height(root.getRight())) + 1);
		int balanceFactor = balanceFactor(root);
		if (balanceFactor < -1) {
			if (balanceFactor(root.getRight()) > 0) {
				root.setRight(rotateRight(root.getRight()));
				return rotateLeft(root);
			} else {
				return rotateLeft(root);
			}
		} else if (balanceFactor > 1) {
			if (balanceFactor(root.getLeft()) < 0) {
				root.setLeft(rotateLeft(root.getLeft()));
				return rotateRight(root);
			} else {
				return rotateRight(root);
			}
		}
		return root;

	}

	public int balanceFactor(AVLNode node) {
		if (node == null) {
			return 0;
		}
		return height(node.getLeft()) - height(node.getRight());
	}

	private AVLNode rotateLeft(AVLNode node) {

		AVLNode r = node.getRight();
		node.setRight(r.getLeft());
		r.setLeft(node);
		node.setHeight(Math.max(height(node.getLeft()), height(node.getRight())) + 1);
		r.setHeight(Math.max(height(r.getLeft()), height(r.getRight())) + 1);
		return r;

	}

	private AVLNode rotateRight(AVLNode node) {

		AVLNode l = node.getLeft();
		node.setLeft(l.getRight());
		l.setRight(node);
		node.setHeight(Math.max(height(node.getLeft()), height(node.getRight())) + 1);
		l.setHeight(Math.max(height(l.getLeft()), height(l.getRight())) + 1);
		return l;

	}

	private int height(AVLNode node) {
		if (node == null) {
			return 0;
		}
		return node.getHeight();
	}

	private AVLNode minValueNode(AVLNode node) {

		AVLNode current = node;
		while (current.getLeft() != null) {
			current = current.getLeft();
		}
		return current;

	}

	public void inOrder(AVLNode node, ArrayList result){
        if(node != null){
            inOrder(node.getLeft(), result);
            result.add(node.getValue());
            inOrder(node.getRight(), result);
        }
    }
	
	 public void inOrderDesc(AVLNode node, ArrayList result){
	        if(node != null){
	            inOrderDesc(node.getRight(), result);
	            result.add(node.getValue());
	            inOrderDesc(node.getLeft(), result);
	        }
	    }
	
}
