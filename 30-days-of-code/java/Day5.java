import java.util.*;

class Day5 {
    public static void main(String[] args) {
        // create scanner
        Scanner in = new Scanner(System.in);

        // read input
        int input = in.nextInt();

        // close scanner
        in.close();

        // print multiplication table
        for (int i = 1; i < 11; i++)
            System.out.println(input + " x " + i + " = " + input * i);
    }
}
