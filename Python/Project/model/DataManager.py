import os.path


class DataManager:

    my_path = os.path.dirname(__file__)
    path_10000 = os.path.join(my_path, "../data/set10000.txt")
    path_100000 = os.path.join(my_path, "../data/set100000.txt")
    path_1000000 = os.path.join(my_path, "../data/set1000000.txt")

    def __init__(self):
        pass

    def read_file1(self):

        with open(self.path_10000, 'r') as f:
            output = []
            for line in f.readlines():
                output.append(int(line))

        return output

    def read_file2(self):

        with open(self.path_100000, 'r') as f:
            output = list()
            for line in f.readlines():
                output.append(int(line))

        return output

    def read_file3(self):

        with open(self.path_1000000, 'r') as f:
            output = list()
            for line in f.readlines():
                output.append(int(line))

        return output
