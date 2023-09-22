package com.joblack.alsafar.dto.tourPocket;

import com.fasterxml.jackson.annotation.JsonProperty;
import lombok.Data;

import java.time.LocalDate;

@Data
public class TourPocketGetDto {

    private String destination;

    private int length;

    private LocalDate startDate;

    private LocalDate endDate;

    private Double price;

    private Long numberOfSeats;
}
