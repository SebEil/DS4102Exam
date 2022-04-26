import axios from "axios";
import { ref } from 'vue'

const vehicleService = (function(){

    const vehicles = ref([]);

    const vehiclesControllerUrl = "https://localhost:7203/Vehicle";

    ( async ()=>{
        const request = await axios.get(vehiclesControllerUrl);
        vehicles.value = request.data;
    })()

    const getAllVehicles = () => vehicles;

    const postVehicles = ( newVehicles ) =>

    vehicles.value.push(newVehicles)

    return {
        getAllVehicles,
        postVehicles
    }
}())

export default vehicleService;