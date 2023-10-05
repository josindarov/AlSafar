package com.joblack.alsafar.repository;

import com.joblack.alsafar.entities.TourPocket;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface TourPocketRepository extends JpaRepository<TourPocket, Long> {

    TourPocket getTourPocketByDestination();

    TourPocket getTourPocketByStartDate();

    void deleteTourPocketByDestination();

}
