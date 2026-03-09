import java.util.HashMap;

public class HelloWorld{

    public static void main(String[] args){
        HashMap<String, String> myHashMap = new HashMap<String, String>();
        myHashMap.put("England", "London");
        myHashMap.put("California", "Sacramento");

        System.out.println("Hello World!");
        System.out.println("My Hash Map:");
        System.out.println(myHashMap);
        System.out.println(myHashMap.get("California"));
        System.out.println(myHashMap.keySet());
    }
}