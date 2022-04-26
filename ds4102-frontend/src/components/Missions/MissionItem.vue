<template>
    <article>
        <h3>MissionId: {{ missionId }}</h3>
        <h3>Operation Name: {{missionName}}</h3>
        <h3>Operation Location: {{missionLocation}}</h3>
        <h3>Soldiers deployed for mission: {{soldiersDeployed}}</h3>
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