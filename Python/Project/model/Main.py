import random


def generate_set(size):
    output = []
    for i in range(size):
        output.append(random.randint(1, 500))
    return output


def main():

    import time
    from model.DataManager import DataManager
    from model.HeapSort import HeapSort
    from model.AVLTree import AVLNode
    from model.AVLTree import AVLTree

    # instantiate objects to read and sort
    dm = DataManager()

    # read the files
    array_1 = dm.read_file1()
    array_2 = dm.read_file2()
    array_3 = dm.read_file3()

    print("--------------------HeapSort Algorithm-------------------------------------------------------------------")
    heap_sorter = HeapSort(len(array_1))
    print("\n")
    start_time = time.time()
    heap_sorter.sort(array_1)
    end_time = time.time()
    total_time = end_time - start_time
    print("Total time elapsed while sorting array of 10000 integers: ")
    print(total_time)

    heap_sorter = HeapSort(len(array_2))
    print("\n")
    start_time = time.time()
    heap_sorter.sort(array_2)
    end_time = time.time()
    total_time = end_time - start_time
    print("Total time elapsed while sorting array of 100000 integers: ")
    print(total_time)

    heap_sorter = HeapSort(len(array_3))
    print("\n")
    start_time = time.time()
    heap_sorter.sort(array_3)
    end_time = time.time()
    total_time = end_time - start_time
    print("Total time elapsed while sorting array of 1000000 integers: ")
    print(total_time)
    print("--------------------HeapSort Algorithm------------------------------------------------------------------")

    print("\n")
    print("--------------------TreeSort Algorithm------------------------------------------------------------------")
    start_time = time.time()
    tree = AVLTree()
    for i in range(0, len(array_1)):
        tree.insert(array_1[i])
    sorted_arr = []
    tree.in_order(tree.root, sorted_arr)
    end_time = time.time()
    total_time = end_time - start_time
    print("Total time elapsed while sorting array of 10000 integers: ")
    print(total_time)

    start_time = time.time()
    tree = AVLTree()
    for i in range(0, len(array_2)):
        tree.insert(array_2[i])
    sorted_arr = []
    tree.in_order(tree.root, sorted_arr)
    end_time = time.time()
    total_time = end_time - start_time
    print("Total time elapsed while sorting array of 100000 integers: ")
    print(total_time)

    start_time = time.time()
    tree = AVLTree()
    for i in range(0, len(array_3)):
        tree.insert(array_3[i])
    sorted_arr = []
    tree.in_order(tree.root, sorted_arr)
    end_time = time.time()
    total_time = end_time - start_time
    print("Total time elapsed while sorting array of 1000000 integers: ")
    print(total_time)
    print("--------------------TreeSort Algorithm------------------------------------------------------------------")



if __name__ == "__main__":
    main()
