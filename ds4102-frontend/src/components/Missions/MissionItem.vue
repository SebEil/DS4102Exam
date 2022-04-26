<template>
    <article>
        <h3>{{ missionId }} {{missionName}} {{missionLocation}} {{soldiersDeployed}}</h3>
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