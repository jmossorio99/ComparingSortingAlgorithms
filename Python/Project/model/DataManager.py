import os.path


class DataManager:

    my_path = os.path.dirname(__file__)
    path_10 = os.path.join(my_path, "../data/set10.txt")
    path_100 = os.path.join(my_path, "../data/set100.txt")
    path_1000 = os.path.join(my_path, "../data/set1000.txt")

    def __init__(self):
        pass

    def read_file1(self):

        with open(self.path_10, 'r') as f:
            output = []
            for line in f.readlines():
                output.append(int(line))

        return output

    def read_file2(self):

        with open(self.path_100, 'r') as f:
            output = list()
            for line in f.readlines():
                output.append(int(line))

        return output

    def read_file3(self):

        with open(self.path_1000, 'r') as f:
            output = list()
            for line in f.readlines():
                output.append(int(line))

        return output
