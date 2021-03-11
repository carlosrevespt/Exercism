import java.util.List;
import java.util.ArrayList;

class ResistorColorDuo {
	
	List<String> resistors = new ArrayList<>();
	
	ResistorColorDuo () {
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
	
    int value(String[] colors) {
        int code = resistors.indexOf(colors[0]);
		
		return colors.length > 1 ? code * 10 + resistors.indexOf(colors[1]) : code;
    }
}
