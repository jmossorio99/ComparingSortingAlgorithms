class HeapSort:

    def __init__(self, size):
        from model.MinHeap import MinHeap
        self.min_heap = MinHeap(size)

    def sort(self, array=[]):
        output = []
        for i in range(0, len(array)):
            self.min_heap.add(array[i])
        while not self.min_heap.is_empty():
            output.append(self.min_heap.pop())
        return output
