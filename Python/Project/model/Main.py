
def main():

    from model.DataManager import DataManager
    from model.TimSort import TimSort

    # instantiate objects to read and sort
    dm = DataManager()
    tim_sorter = TimSort()

    # read the file
    array_1 = dm.read_file1()
    array_2 = dm.read_file2()
    array_3 = dm.read_file3()

    # print unsorted array and then print sorted
    print(array_1)
    tim_sorter.tim_sort(array_1)
    print(array_1)

    print("\n")

    print(array_2)
    tim_sorter.tim_sort(array_2)
    print(array_2)

    print("\n")

    print(array_3)
    tim_sorter.tim_sort(array_3)
    print(array_3)


if __name__ == "__main__":
    main()
