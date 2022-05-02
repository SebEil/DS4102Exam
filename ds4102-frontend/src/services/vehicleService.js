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

    const getById = async (vehicleId) => {
        const request = await axios.get(`https://localhost:7203/vehicle/${vehicleId}`)
        return request.data;
    }

    const putVehicle = async (editedVehicle) => {
        await axios.put("https://localhost:7203/vehicle", editedVehicle)
        
        const temporaryVehicleArray = JSON.parse( JSON.stringify( vehicles.value ))

        const index = temporaryVehicleArray.findIndex( vehicle => parseInt( vehicle.id ) === parseInt( editedVehicle.id ) );

        vehicles.value[index].vehicleType = editedVehicle.vehicleName;
        vehicles.value[index].numberOfSeats = editedVehicle.numberOfSeats;

    }


    const postVehicles = ( newVehicle ) => {
        axios.post( vehiclesControllerUrl, newVehicle )
        vehicles.value.push(newVehicle);
    }

    const deleteVehicle = async ( vehicleToDelete ) => {
        await axios.delete(`https://localhost:7203/vehicle/${vehicleToDelete}`)
        
    }

    return {
        getAllVehicles,
        postVehicles,
        deleteVehicle,
        putVehicle,
        getById
    }
}())

export default vehicleService;