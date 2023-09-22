package com.joblack.alsafar.dto.tourFirm;

import com.fasterxml.jackson.annotation.JsonProperty;
import lombok.Data;

@Data
public class TourFirmPostDto {

    @JsonProperty("name")
    private String name;

    @JsonProperty("email")
    private String email;


}
