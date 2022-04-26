<template>
    <article class="vehicleContainer">
        <h3>Vehicle Id: {{ vehicleId }}</h3>
        <h3>VehicleType: {{ vehicleType }}</h3>
        <h3>Number of seats: {{ numberOfSeats }}</h3>
    </article>
</template>

<script>
export default {
    props: {
        vehicleId : Number,
        vehicleType : String,
        numberOfSeats : Number
    }
}
</script>

<style scoped>

    article{ border: 1px solid black;}

    .vehicleContainer {
        border-radius: 25px;
        margin: 0.5rem;
        
        min-width: 400px;
        max-width: 500px;
        padding: 3rem;
    }

</style>