import java.util.*;

class Person {
    // propertiees
    int age;

    // constructor
    Person(int age) {
        // check if valid age
        if (age >= 0) {
            this.age = age;
        } else {
            System.out.println("Age is not valid, setting age to 0.");
            this.age = 0;
        }
    }

    void yearPasses() {
        // increment age
        age++;
    }

    String amIOld() {
        // return age statement
        if (age < 13)
            return "You are young.";
        if (age < 18)
            return "You are a teenager.";

        return "You are old.";
    }
}

class Day4 {
    public static void main(String[] args) {
        // create scanner
        Scanner in = new Scanner(System.in);

        // read total input numbers
        int times = in.nextInt();

        // close scanner
        in.close();

        // loop number of times
        for (int i = 0; i < times; i++) {
            // instantiate a person
            Person p = new Person(in.nextInt());

            // print age statement
            System.out.println(p.amIOld());

            // increment person age
            for (int j = 0; j < 3; j++)
                p.yearPasses();

            // print age statement
            System.out.println(p.amIOld());
        }
    }
}
