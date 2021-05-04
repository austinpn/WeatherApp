import React from 'react';
import HourlyWeatherSegment from "./HourlyWeatherSegment";

class HourlyWeather extends React.Component {
    constructor(props) {
        super(props);
        //TODO set up anync loading
        // console.log(this.props);
        this.state = {
            periods: null,
            latitude: this.props.latitude,
            longitude: this.props.longitude,
            numDays: this.props.numDays,
            stillFetching: true
        }
        this.populateHourPeriods = this.populateHourPeriods.bind(this);

    }

    componentDidMount() {
        setTimeout(this.populateHourPeriods, 1000);
    }

    render() {
        let contents = this.state.stillFetching ? 
            <p>Loading...</p> : 
            this.state.periods.map((period) => {
                return(<HourlyWeatherSegment period={period}/>);
            });
        return (
            <div className="HourlyWeather">
                {contents}
            </div>
            )
    }

    async populateHourPeriods(){
        console.log(this.state);
        const response = await fetch(`https://localhost:5001/forecast/${this.props.longitude}&${this.props.latitude}&${this.props.numDays}/hourly/wind`);
        const data = await response.json();
        console.log(data);
        this.setState({periods: data, stillFetching: false});
    }
}

export default HourlyWeather;