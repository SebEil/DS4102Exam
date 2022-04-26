<template>
    <article class="missionContainer">
        <h3>Mission Id: {{ missionId }}</h3>
        <h3>Operation Name: {{ missionName }}</h3>
        <h3>Operation Location: {{ missionLocation }}</h3>
        <h3>Soldiers deployed for mission: {{ soldiersDeployed }}</h3>
    </article>
</template>

<script>
export default {
    props: {
        missionId : Number,
        missionName : String,
        missionLocation : String,
        soldiersDeployed : Number
    }
}
</script>

<style scoped>

    article{ border: 1px solid black;}

    .missionContainer {
        border-radius: 25px;
        margin: 0.5rem;
        
        min-width: 400px;
        max-width: 500px;
        padding: 3rem;
    }

</style>