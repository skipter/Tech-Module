import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import java.util.Scanner;

public class CountWorkDays {
    public static void main(String[] args) throws ParseException {

        Scanner scanner = new Scanner(System.in);

        SimpleDateFormat format = new SimpleDateFormat("dd-MM-yyyy");

        Date date1 = format.parse(scanner.nextLine());
        Date endDate = format.parse(scanner.nextLine());

        int workDays = 0;

        Calendar calendar = Calendar.getInstance();

        while (date1.compareTo(endDate) != 1) {
            calendar.setTime(date1);

            boolean isHoliday = checkCurrentDay(date1);

            if (!isHoliday) {
                workDays++;
            }
            calendar.add(Calendar.DAY_OF_MONTH, 1);
            date1 = calendar.getTime();

        }
        System.out.println(workDays);
    }

    private static boolean checkCurrentDay(Date date) {

        Calendar calendar = Calendar.getInstance();
        calendar.setTime(date);

        int weekDays = calendar.get(Calendar.DAY_OF_WEEK);

        if (weekDays == Calendar.SUNDAY || weekDays == Calendar.SATURDAY) {
            return true;
        }

        int monthDay = calendar.get(Calendar.DAY_OF_MONTH);
        switch (calendar.get(Calendar.MONTH)) {

            case Calendar.JANUARY:
                if(monthDay == 1) {
                    return  true;
                }
                break;
            case Calendar.MARCH:
                if(monthDay == 3) {
                    return  true;
                }
                break;
            case Calendar.MAY:
                if(monthDay == 1 || monthDay == 6 || monthDay == 24) {
                    return  true;
                }
                break;
            case Calendar.SEPTEMBER:
                if(monthDay == 6 || monthDay == 22) {
                    return  true;
                }
                break;
            case Calendar.NOVEMBER:
                if(monthDay == 1) {
                    return  true;
                }
                break;
            case Calendar.DECEMBER:
                if(monthDay == 24 || monthDay == 25 || monthDay == 26) {
                    return  true;
                }
                break;
        }
        return false;
    }
}
