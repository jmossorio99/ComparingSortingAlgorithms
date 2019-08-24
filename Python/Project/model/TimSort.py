class TimSort:

    def __init__(self):
        pass

    def merge(self, arr, left, mid, right):
        # break array into to
        len1 = mid - left + 1
        len2 = right - mid
        left_arr = []
        right_arr = []
        for i in range(0, len1):
            left_arr.append(arr[left + i])
        for j in range(0, len2):
            right_arr.append(arr[mid + 1 + j])

        a = 0
        b = 0
        sub_start_index = left
        while a < len1 and b < len2:

            if left_arr[a] <= right_arr[b]:
                arr[sub_start_index] = left_arr[a]
                a += 1
            else:
                arr[sub_start_index] = right_arr[b]
                b += 1
            sub_start_index += 1

        while a < len1:
            arr[sub_start_index] = left_arr[a]
            a += 1
            sub_start_index += 1

        while b < len2:
            arr[sub_start_index] = right_arr[b]
            b += 1
            sub_start_index += 1

    def insertion_sort(self, arr, left, right):

        for i in range(left + 1, right + 1):

            key = arr[i]
            j = i - 1
            while arr[j] > key and j >= left:
                arr[j + 1] = arr[j]
                j -= 1
            arr[j + 1] = key

    def tim_sort(self, arr):

        run = 32
        for i in range(0, len(arr), run):
            # this takes a portion of the big array starting at i
            # and going until: i + 31 because the run variable, which is the factor
            # we are using to split the array, is 32. However, if the array's remaining
            # positions are smaller than i + 31, then it will end at len(arr)-1
            self.insertion_sort(arr, i, min((i + 31), (len(arr) - 1)))

        # this variable size will be incrementing to form size 64, 128, 256 and so on
        size = run
        while size < len(arr):

            for left in range(0, len(arr), 2 * size):

                # find ending point of left sub array and starting point of right sub array
                mid = left + size - 1
                right = min((left + 2 * size - 1), (len(arr) - 1))

                # merge sub array[left...mid] & sub array[mid+1...right]
                self.merge(arr, left, mid, right)

            size = size * 2

