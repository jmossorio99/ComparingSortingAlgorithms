
def main():

    import time
    from model.DataManager import DataManager
    from model.TimSort import TimSort
    from model.HeapSort import HeapSort

    # instantiate objects to read and sort
    dm = DataManager()
    tim_sorter = TimSort()

    print("--------------------HeapSort Algorithm-------------------------------------------------------------------")
    # read the file
    array_1 = dm.read_file1()
    heap_sorter = HeapSort(len(array_1))
    print("\n")
    print(array_1)
    start_time = time.time()
    heap_sorter.sort(array_1)
    print(array_1)
    end_time = time.time()
    total_time = end_time - start_time
    print("Total time elapsed while sorting array of 10000 integers: ")
    print(total_time)
    print("--------------------HeapSort Algorithm-------------------------------------------------------------------")
    array_2 = dm.read_file2()
    array_3 = dm.read_file3()

    # print unsorted array and then print sorted
    print("--------------------TimSort Algorithm-------------------------------------------------------------------")
    print("\n")
    start_time = time.time()
    tim_sorter.tim_sort(array_1)
    end_time = time.time()
    total_time = end_time - start_time
    print("Total time elapsed while sorting array of 10000 integers: ")
    print(total_time)

    print("\n")

    # print unsorted array and then print sorted
    start_time = time.time()
    tim_sorter.tim_sort(array_2)
    end_time = time.time()
    total_time = end_time - start_time
    print("Total time elapsed while sorting array of 100000 integers: ")
    print(total_time)

    print("\n")

    # print unsorted array and then print sorted
    start_time = time.time()
    tim_sorter.tim_sort(array_3)
    end_time = time.time()
    total_time = end_time - start_time
    print("Total time elapsed while sorting array of 1000000 integers: ")
    print(total_time)
    print("\n")
    print("--------------------TimSort Algorithm-------------------------------------------------------------------")
    print("\n")


if __name__ == "__main__":
    main()
