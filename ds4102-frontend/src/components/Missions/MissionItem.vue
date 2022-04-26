<template>
    <section class="missionContainer">
        <h3>MissionId: {{ MissionId }}</h3>
        <h3>Operation Name: {{ MissionName }}</h3>
        <h3>Operation Location: {{ MissionLocation }}</h3>
        <h3>Soldiers deployed for mission: {{ SoldiersDeployed }}</h3>
    </section>
</template>

<script>
export default {
    props: {
        MissionId : Number,
        MissionName : String,
        MissionLocation : String,
        SoldiersDeployed : Number
    }
}
</script>

<style scoped>

    section{ border: 1px solid black;}

    .missionContainer {
        border-radius: 25px;
        margin: 0.5rem;
        
        min-width: 400px;
        padding: 3rem;
    }

</style>