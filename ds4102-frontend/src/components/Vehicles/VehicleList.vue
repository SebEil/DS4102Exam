<template>
    <section>
        <article class="row align d-flex justify-content-center">
        <vehicle-item
            class="container col p-2 text-center" v-for="(vehicle, i) in vehicles"
            :key="i"
            :vehicleId="vehicle.vehicleId"
            :vehicleType="vehicle.vehicleType"
            :numberOfSeats="vehicle.numberOfSeats">
            </vehicle-item>
        </article>
    </section>
</template>

<script>
import VehicleItem from "../Vehicles/VehicleItem.vue"
import vehicleService from "../../services/vehicleService.js"

export default {
    setup(){
        const vehicles = vehicleService.getAllVehicles();

        return{
            vehicles
        }
    },
    components: {
        VehicleItem
    }   
}
</script>

<style>
    .container{
        padding: 1rem;
        background-color: rgb(161, 148, 148);
        border-radius: 25px;
        margin-bottom: 1rem;
        display: inline-block;
    }


</style>