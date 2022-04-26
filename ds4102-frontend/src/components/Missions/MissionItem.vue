<template>
    <article>
        <h3>MissionId: {{ MissionId }}</h3>
        <h3>Operation Name: {{ MissionName }}</h3>
        <h3>Operation Location: {{ MissionLocation }}</h3>
        <h3>Soldiers deployed for mission: {{ SoldiersDeployed }}</h3>
    </article>
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