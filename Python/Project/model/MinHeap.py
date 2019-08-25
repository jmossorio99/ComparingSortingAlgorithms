class MinHeap:

    def __init__(self, size):
        self.heap = [1000000] * size
        self.num_elements = 0

    def get_left(self, i):
        return i * 2 + 1

    def get_right(self, i):
        return i * 2 + 2

    def get_parent(self, i):
        return (i - 1)//2

    def has_left(self, i):
        return self.get_left(i) < self.num_elements

    def has_right(self, i):
        return self.get_right(i) < self.num_elements

    def is_root(self, i):
        return i == 0

    def get_left_value(self, i):
        return self.heap[self.get_left(i)]

    def get_right_value(self, i):
        return self.heap[self.get_right(i)]

    def get_parent_value(self, i):
        return self.heap[self.get_parent(i)]

    def swap(self, i, j):
        self.heap[i], self.heap[j] = self.heap[j], self.heap[i]

    def is_empty(self):
        return self.num_elements == 0

    def peek(self):
        if self.num_elements == 0:
            return None
        else:
            return self.heap[0]

    def pop(self):
        if self.num_elements == 0:
            return None
        else:
            elem = self.heap[0]
            self.heap[0] = self.heap[self.num_elements - 1]
            self.num_elements -= 1
            self.recalculate_down()
            return elem

    def add(self, elem):
        if self.num_elements == len(self.heap):
            return None
        else:
            self.heap[self.num_elements] = elem
            self.num_elements += 1
            self.recalculate_up()

    def recalculate_down(self):
        index = 0
        while self.has_left(index):
            smallest_index = self.get_left(index)
            if self.has_right(index) and self.get_right_value(index) < self.get_left_value(index):
                smallest_index = self.get_right(index)
            if self.heap[smallest_index] >= self.heap[index]:
                break
            self.swap(smallest_index, index)
            index = smallest_index

    def recalculate_up(self):
        index = self.num_elements - 1
        while (not self.is_root(index)) and self.heap[index] < self.get_parent_value(index):
            parent_index = self.get_parent(index)
            self.swap(parent_index, index)
            index = parent_index
