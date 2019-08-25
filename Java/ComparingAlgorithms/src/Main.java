import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.Arrays;

public class Main {

	public static void main(String[] args) {
		File file100 = new File("Data/set100.txt");
		File file1000 = new File("Data/set1000.txt");
		File file10000 = new File("Data/set10000.txt");
		readFile(file100, 100);
		readFile(file1000, 1000);
		readFile(file10000, 10000);
//		int[] test1 = {9,8,7,6,5,4,3,2,1,0};
//		int[] test2 = {9,8,7,6,5,4,3,2,1,0};
//		Heap heap = new Heap(test1, test1.length + 2);
//		int[] result = heap.heapSort(10);
//		for (int i = 0; i < result.length; i++) {
//			System.out.print(" " + result[i]);
//		}
//		System.out.print("]");
//		Arrays.sort(test2);
//		System.out.print("[");
//		for (int i = 0; i < test2.length; i++) {
//			System.out.print(" " + test2[i]);
//		}
//		System.out.print("]");
	}

	public static void readFile(File file, int size) {
		
		try {
			BufferedReader buff = new BufferedReader(new FileReader(file));
			int[] first = new int[size];
			int[] second = new int[size];
			String current = buff.readLine();
			int currentNum = 0;
			while(current != null) {
				first[currentNum] = Integer.parseInt(current);
				second[currentNum] = Integer.parseInt(current);
				currentNum++;
				current = buff.readLine();
			}
			long startTime = System.currentTimeMillis();
			Arrays.sort(first);
			long endTime = System.currentTimeMillis();
			long total = endTime - startTime;
			System.out.println("Timsort takes: "+ total + "ms");
			Heap heap = new Heap(second, second.length + 2);
			startTime = System.currentTimeMillis();
			heap.heapSort(size);
			endTime = System.currentTimeMillis();
			total = endTime - startTime;
			System.out.println("Heapsort takes: "+ total + "ms");
			buff.close();
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}
		
	}
	
}
