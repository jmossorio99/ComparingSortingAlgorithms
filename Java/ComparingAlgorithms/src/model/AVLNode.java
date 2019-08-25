package model;

public class AVLNode {

	private AVLNode left;
	private AVLNode right;
	public int level;
	private int height;
	private int value;

	public AVLNode(int value, AVLNode left, AVLNode right) {

		this.value = value;
		this.left = left;
		this.right = right;
		height = 1;

	}
	
	public int getValue() {
		return value;
	}

	public void setValue(int Value) {
		this.value = value;
	}

	public AVLNode getLeft() {
		return left;
	}

	public void setLeft(AVLNode left) {
		this.left = left;
	}

	public AVLNode getRight() {
		return right;
	}

	public void setRight(AVLNode right) {
		this.right = right;
	}

	public void setHeight(int depth) {
		this.height = depth;
	}

	public int getHeight() {
		return height;
	}

	public int compare(AVLNode o) {
		if(this.value > o.getValue()) {
			return 1;
		}else if(this.value < o.getValue()) {
			return -1;
		}else {
			return 0;
		}
	}

}
