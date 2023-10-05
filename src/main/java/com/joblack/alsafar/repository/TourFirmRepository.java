package com.joblack.alsafar.repository;

import com.joblack.alsafar.entities.TourFirm;
import com.joblack.alsafar.entities.TourPocket;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface TourFirmRepository extends JpaRepository<TourFirm, Long> {

    void findTourFirmByName();
    void deleteTourFirmByName();
}
