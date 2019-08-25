class TimSort:

    def __init__(self):
        pass

    def merge(self, arr_a, arr_b):
        # break array into two
        a = 0
        b = 0
        arr_c = []
        while a < len(arr_a) and b < len(arr_b):
            if arr_a[a] < arr_b[b]:
                arr_c.append(arr_a[a])
                a += 1
            elif arr_a[a] > arr_b[b]:
                arr_c.append(arr_b[b])
                b += 1
            else:
                arr_c.append(arr_a[a])
                arr_c.append(arr_b[b])
                a += 1
                b += 1

        while a < len(arr_a):
            arr_c.append(arr_a[a])
            a += 1
        while b < len(arr_b):
            arr_c.append(arr_b[b])
            b += 1

        return arr_c

    def insertion_sort(self, arr):

        for i in range(1, len(arr)):

            for j in range(i, 0, -1):

                if arr[i] < arr[i - 1]:
                    t = arr[i]
                    arr[i] = arr[i - 1]
                    arr[i - 1] = t
                else:
                    break
                j = j - 1
        return arr

    def tim_sort(self, arr):

        run = 64
        for i in range(0, len(arr), run):
            # this sorts the sub array from 0 to run
            arr[i: i + run] = self.insertion_sort(arr[i: i + run])

        # this variable size will be incrementing to form size 64, 128, 256 and so on
        size = run
        while size < len(arr):

            for j in range(0, len(arr), 2 * size):
                arr[j: j + 2 * size] = self.merge(arr[j: j + size], arr[j + size: j + 2 * size])
            size = size * 2

