package com.joblack.alsafar.dto.tourPocket;

import com.fasterxml.jackson.annotation.JsonProperty;
import lombok.Data;

import java.time.LocalDate;

@Data
public class TourPocketPostDto {

    @JsonProperty("destination")
    private String destination;

    @JsonProperty("length")
    private int length;

    @JsonProperty("startDate")
    private LocalDate startDate;

    @JsonProperty("endDate")
    private LocalDate endDate;

    @JsonProperty("price")
    private Double price;

    @JsonProperty("numberOfSeats")
    private Long numberOfSeats;

    @JsonProperty("tourFirmId")
    private Long tourFirmId;



}
