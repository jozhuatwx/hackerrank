import java.util.*;

class Day1 {
    public static void main(String[] args) {
        // initialisation
        int i = 4;
        double d = 4.0;
        String s = "HackerRank ";

        // create scanner
        Scanner in = new Scanner(System.in);

        // read input
        int i2 = in.nextInt();
        double d2 = in.nextDouble();
        // skip line
        in.nextLine();
        String s2 = in.nextLine();

        // close scanner
        in.close();

        // print sum statement
        System.out.println(i + i2);
        System.out.println(d + d2);
        System.out.println(s + s2);
    }
}
