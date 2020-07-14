import java.util.*;

class Day6 {
    public static void main(String[] args) {
        // create scanner
        Scanner in = new Scanner(System.in);

        // read total input strings
        int times = in.nextInt();
        // skip line
        in.nextLine();

        // loop number of times
        for (int i = 0; i < times; i++) {
            // read input
            String input = in.nextLine();

            // print even characters
            for (int j = 0; j < input.length(); j = j + 2)
            System.out.print(input.charAt(j));

            // print spacing
            System.out.print(" ");

            // print odd characters
            for (int j = 1; j < input.length(); j = j + 2)
                System.out.print(input.charAt(j));
            
            // print new line
            System.out.println();
        }

        // close scanner
        in.close();
    }
}
