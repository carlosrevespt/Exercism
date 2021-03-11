import java.util.List;
import java.util.ArrayList;

class ResistorColor {
	
	List<String> resistors = new ArrayList<>();
	
	ResistorColor () {
		resistors.add ("black");
		resistors.add ("brown");
		resistors.add ("red");
		resistors.add ("orange");
		resistors.add ("yellow");
		resistors.add ("green");
		resistors.add ("blue");
		resistors.add ("violet");
		resistors.add ("grey");
		resistors.add ("white");
	}
	
    int colorCode(String color) {
        		
		return resistors.indexOf(color);
    }

    String[] colors() {
        return resistors.toArray(new String[resistors.size()]);
    }
}
