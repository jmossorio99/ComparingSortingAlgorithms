
class AVLNode:
    def __init__(self, data):
        self.data = data
        self.left = None
        self.right = None
        self.parent = None
        self.bf = 0


class AVLTree:

    def __init__(self):
        self.root = None


    def __search_tree_helper(self, node, data):
        if node == None or data == node.data:
            return node
        if data < node.data:
            return self.__search_tree_helper(node.left, data)
        return self.__search_tree_helper(node.right, data)

    def __update_balance(self, node):
        if node.bf < -1 or node.bf > 1:
            self.__rebalance(node)
            return
        if node.parent != None:
            if node == node.parent.left:
                node.parent.bf -=1

            if node == node.parent.right:
                node.parent.bf += 1

            if node.parent.bf != 0:
                self.__update_balance(node.parent)

    def __rebalance(self, node):
        if node.bf > 0:
            if node.right.bf < 0:
                self.right_rotate(node.right)
                self.left_rotate(node)
            else:
                self.left_rotate(node)

        elif node.bf < 0:
            if node.left.bf > 0:
                self.left_rotate(node.left)
                self.right_rotate(node)
            else:
                self.right_rotate(node)

    def in_order(self, node, result):
        if node != None:
            self.in_order(node.left, result)
            result.append(node.data)
            self.in_order(node.right, result)

    def in_order_desc(self, node, result):
        if node != None:
            self.in_order(node.right, result)
            result.append(node.data)
            self.in_order(node.left, result)

    def search_tree(self, data):
        return self.__search_tree_helper(self.root, data)

    def minimum(self, node):
        while node.left is not None:
            node = node.left
        return node

    def maximum(self, node):
        while node.right is not None:
            node = node.right
        return node

    def successor(self, node):
        if node.right is not None:
            return self.minimum(node.right)
        p = node.parent
        while p is not None and node == p.right:
            node = p
            p = p.parent
        return p

    def predecessor(self, node):
        if node.left is not None:
            return self.maximum(node.left)
        p = node.parent
        while p is not None and node == p.left:
            node = p
            p = p.parent
        return p

    def left_rotate(self, x):
        y = x.right
        x.right = y.left
        if y.left is not None:
            y.left.parent = x
        y.parent = x.parent
        if x.parent is None:
            self.root = y
        elif x == x.parent.left:
            x.parent.left = y
        else:
            x.parent.right = y
        y.left = x
        x.parent = y

        x.bf = x.bf - 1 - max(0, y.bf)
        y.bf = y.bf - 1 + min(0, x.bf)

    def right_rotate(self, x):
        y = x.left
        x.left = y.right
        if y.right is not None:
            y.right.parent = x

        y.parent = x.parent;
        if x.parent is None:
            self.root = y
        elif x == x.parent.right:
            x.parent.right = y
        else:
            x.parent.left = y
        y.right = x
        x.parent = y

        x.bf = x.bf + 1 - min(0, y.bf)
        y.bf = y.bf + 1 + max(0, x.bf)

    def insert(self, data):
        node = AVLNode(data)
        y = None
        x = self.root

        while x is not None:
            y = x
            if node.data < x.data:
                x = x.left
            else:
                x = x.right

        node.parent = y
        if y is None:
            self.root = node
        elif node.data < y.data:
            y.left = node
        else:
            y.right = node

        self.__update_balance(node)
