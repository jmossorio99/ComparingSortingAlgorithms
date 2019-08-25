import random


def generate_set(size):
    output = []
    for i in range(size):
        output.append(random.randint(1, 500))
    return output


def main():

    import time
    from model.DataManager import DataManager
    from model.TimSort import TimSort
    from model.HeapSort import HeapSort

    # instantiate objects to read and sort
    dm = DataManager()
    tim_sorter = TimSort()

    # read the files
    array_1 = dm.read_file1()
    array_2 = dm.read_file2()
    array_3 = dm.read_file3()

    print("--------------------HeapSort Algorithm-------------------------------------------------------------------")
    print(array_1)
    heap_sorter = HeapSort(len(array_1))
    print("\n")
    start_time = time.time()
    print(heap_sorter.sort(array_1))
    end_time = time.time()
    total_time = end_time - start_time
    print("Total time elapsed while sorting array of 10000 integers: ")
    print(total_time)

    heap_sorter = HeapSort(len(array_2))
    print("\n")
    start_time = time.time()
    print(heap_sorter.sort(array_2))
    end_time = time.time()
    total_time = end_time - start_time
    print("Total time elapsed while sorting array of 100000 integers: ")
    print(total_time)

    heap_sorter = HeapSort(len(array_3))
    print("\n")
    start_time = time.time()
    print(heap_sorter.sort(array_3))
    end_time = time.time()
    total_time = end_time - start_time
    print("Total time elapsed while sorting array of 1000000 integers: ")
    print(total_time)
    print("--------------------HeapSort Algorithm------------------------------------------------------------------")

    print("--------------------TimSort Algorithm-------------------------------------------------------------------")
    print("\n")
    print(array_1)
    start_time = time.time()
    tim_sorter.tim_sort(array_1)
    end_time = time.time()
    total_time = end_time - start_time
    print(array_1)
    print("Total time elapsed while sorting array of 10000 integers: ")
    print(total_time)

    print("\n")
    start_time = time.time()
    tim_sorter.tim_sort(array_2)
    end_time = time.time()
    total_time = end_time - start_time
    print("Total time elapsed while sorting array of 100000 integers: ")
    print(total_time)

    print("\n")
    start_time = time.time()
    tim_sorter.tim_sort(array_3)
    end_time = time.time()
    total_time = end_time - start_time
    print("Total time elapsed while sorting array of 1000000 integers: ")
    print(total_time)
    print("--------------------TimSort Algorithm-------------------------------------------------------------------")


if __name__ == "__main__":
    main()
