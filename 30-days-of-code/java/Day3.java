import java.util.*;

class Day3 {
    static String conditionalStatement(int i) {
        // return conditional statement
        if (i % 2 != 0)
            return "Weird";
        if (i > 20)
            return "Not Weird";
        if (i >= 6)
            return "Weird";

        return "Not Weird";
    }

    public static void main(String[] args) {
        // create scanner
        Scanner in = new Scanner(System.in);

        // read input
        int i = in.nextInt();

        // close scanner
        in.close();

        // print conditional statement
        System.out.println(conditionalStatement(i));
    }
}
