import os.path


def merge(arr1, left, mid, right):
    # break arr1 into two parts
    len1 = mid - left + 1
    len2 = right - mid
    left_arr = []
    right_arr = []
    for i in range(0, len1):
        left_arr.append(arr1[left + i])
    for i in range(0, len2):
        right_arr.append(arr1[mid + 1 + i])

    a = 0
    b = 0
    sub_start_index = left
    while a < len1 and b < len2:

        if left_arr[a] <= right_arr[b]:
            arr1[sub_start_index] = left_arr[a]
            a += 1
        else:
            arr1[sub_start_index] = right_arr[b]
            b += 1
        sub_start_index += 1

    while a < len1:
        arr1[sub_start_index] = left_arr[a]
        a += 1
        sub_start_index += 1

    while b < len2:
        arr1[sub_start_index] = right_arr[b]
        b += 1
        sub_start_index += 1


def insertionSort(arr, left, right):
    for i in range(left + 1, right + 1):

        temp = arr[i]
        j = i - 1

        while arr[j] > temp and j >= left:
            arr[j + 1] = arr[j]
            j -= 1

        arr[j + 1] = temp


class DataManager:
    my_path = os.path.dirname(__file__)
    path_100 = os.path.join(my_path, "../data/set100.txt")
    path_1000 = os.path.join(my_path, "../data/set1000.txt")
    path_10000 = os.path.join(my_path, "../data/set10000.txt")

    def __init__(self):
        pass

    def read_file1(self):

        with open(self.path_100, 'r') as f:
            output = []
            for line in f:
                output.append(int(line))

        return output

    def read_file2(self):

        with open(self.path_1000, 'r') as f:
            output = list()
            for line in f:
                output.append(int(line))

        return output

    def read_file3(self):

        with open(self.path_10000, 'r') as f:
            output = list()
            for line in f:
                output.append(int(line))

        return output

    def tim_sort(self, array_output, run):

        for x in range(0, len(array_output), run):
            insertionSort(array_output, x, min((x + 31), (len(array_output) - 1)))

        run_increment = run
        while run_increment < len(array_output):

            for left in range(0, len(array_output), 2 * run_increment):
                mid = left + run_increment - 1
                right = min((left + 2 * run_increment - 1), len(array_output) - 1)
                merge(array_output, left, mid, right)

            run_increment = run_increment * 2


data_manager = DataManager()
data = data_manager.read_file3()
# data = [10, 56, 2, 1, 56, 8, 9, 20, 58, 5, 6, 3]
print(data)
print("\n")
data_manager.tim_sort(data, 64)
print(data)
