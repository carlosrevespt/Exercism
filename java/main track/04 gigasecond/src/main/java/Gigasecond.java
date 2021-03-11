import java.time.LocalDate;
import java.time.LocalTime;
import java.time.LocalDateTime;

public class Gigasecond {
	
	private LocalDateTime momentPlusGiga;
	static final int GIGA = 1_000_000_000;
	
    public Gigasecond(LocalDate moment) {
        this(LocalDateTime.of(moment, LocalTime.MIDNIGHT));
    }

    public Gigasecond(LocalDateTime moment) {
        momentPlusGiga = moment.plusSeconds(GIGA);
    }

    public LocalDateTime getDateTime() {
        return momentPlusGiga;
    }
}
