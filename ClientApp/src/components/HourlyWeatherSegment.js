import React from 'react';

function HourlyWeatherSegment(props){
    let startTime = (
        () => {
        let tempDate = new Date(props.period.startTime).getHours();
        return tempDate%12 + (tempDate >= 12 ? " AM" : " PM")
    })()
    return(
        <div className="HourlyWeatherSegment">
            <h3>{startTime}</h3>
            <div>{props.period.windSpeedMPH} MpH</div>
        </div>
    )
}

export default HourlyWeatherSegment;