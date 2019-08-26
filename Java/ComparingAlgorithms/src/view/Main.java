package view;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;

import model.Heap;
import model.AVLTree;

public class Main {

	public static void main(String[] args) {
		
		File file10000 = new File("Data/set10000.txt");
		File file100000 = new File("Data/set100000.txt");
		File file1000000 = new File("Data/set1000000.txt");
		double equivalnece = 1000.0;
		long timeTaken11 = executeAlgorithms(file10000, 10000, 1);
		System.out.println("Heapsort takes for 10000: " + (timeTaken11/equivalnece) + "s");
		long timeTaken12 = executeAlgorithms(file10000, 10000, 0);
		System.out.println("Treesort takes for 10000: " + (timeTaken12/equivalnece) + "s");
		long timeTaken21 = executeAlgorithms(file100000, 100000, 1);
		System.out.println("Heapsort takes for 100000: " + (timeTaken21/equivalnece) + "s");
		long timeTaken22 = executeAlgorithms(file100000, 100000, 0);
		System.out.println("Treesort takes for 100000: " + (timeTaken22/equivalnece) + "s");
		long timeTaken31 = executeAlgorithms(file1000000, 1000000, 1);
		System.out.println("Heapsort takes for 1000000: " + (timeTaken31/equivalnece) + "s");
		long timeTaken32 = executeAlgorithms(file1000000, 1000000, 0);
		System.out.println("Treesort takes for 1000000: " + (timeTaken32/equivalnece) + "s");
	}

	public static void print(int[] arr, int n) {
		
        for (int i = 0; i < n; i++) { 
            System.out.print(arr[i] + " "); 
        } 
        System.out.print("\n"); 
        
    } 
	
	public static long executeAlgorithms(File file, int size, int algorithm) {
		if(algorithm == 0) {
			try {
				BufferedReader buff = new BufferedReader(new FileReader(file));
				int[] previous = new int[size];
				String current = buff.readLine();
				AVLTree avl = new AVLTree();
				while(current != null) {
					avl.insert(Integer.parseInt(current));
					current = buff.readLine();
				}
				long startTime = System.currentTimeMillis();
				ArrayList result = new ArrayList<>();
				avl.inOrder(avl.getRoot(), result);
				long endTime = System.currentTimeMillis();
				long total = endTime - startTime;
				buff.close();
				return total;
			} catch (FileNotFoundException e) {
				e.printStackTrace();
			} catch (IOException e) {
				e.printStackTrace();
			}
		}else {
			try {
				BufferedReader buff = new BufferedReader(new FileReader(file));
				int[] previous = new int[size];
				String current = buff.readLine();
				int currentNum = 0;
				while(current != null) {
					previous[currentNum] = Integer.parseInt(current);
					currentNum++;
					current = buff.readLine();
				}
				Heap heap = new Heap(previous, previous.length + 2);
				long startTime = System.currentTimeMillis();
				heap.heapSort(size);
				long endTime = System.currentTimeMillis();
				long total = endTime - startTime;
				buff.close();
				return total;
			} catch (FileNotFoundException e) {
				e.printStackTrace();
			} catch (IOException e) {
				e.printStackTrace();
			}
		}
		return -1;
	}
	
}
